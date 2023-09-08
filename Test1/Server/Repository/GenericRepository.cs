using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Test1.Server.Data;
using Test1.Server.IRepository;

namespace Test1.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public async Task Delete(int id)
        {
            var record = await _db.FindAsync(id);
            _db.Remove(record);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.Any(e => entities.Contains(e)); 
            _db.RemoveRange(entities);
        }

        // includes are delegate func defining what objects to include in the query,
        // so the whole object gets properly passed on in the requested parent object
        //
        public async Task<T> Get(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;
			if (includes != null)
			{
				query = includes(query);
			}
            var result = await query.AsNoTracking().Where(expression).ToListAsync();
			return result.FirstOrDefault();
        }

		// includes are delegate func defining what objects to include in the query,
		// so the whole object gets properly passed on in the requested parent object
		//
		public async Task<IList<T>> GetAll(Expression<Func<T, bool>>? expression,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
			Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (includes != null)
            {
                query = includes(query);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

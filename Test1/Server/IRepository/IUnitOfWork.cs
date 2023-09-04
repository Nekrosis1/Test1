using Test1.Shared.Domain;

namespace Test1.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }



    }
}

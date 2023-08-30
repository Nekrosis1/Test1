using Test1.Shared.Domain;

namespace Test1.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
        IGenericRepository<Make> Makes { get; }
        //IGenericRepository<Model> Models { get;}
        //IGenericRepository<Vehicle> Vehicles { get;}


    }
}

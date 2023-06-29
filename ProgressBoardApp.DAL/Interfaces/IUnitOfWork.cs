using ProgressBoardApp.Domain.Entities;

namespace ProgressBoardApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        void Save();
    }
}

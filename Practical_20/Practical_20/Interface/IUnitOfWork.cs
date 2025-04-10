using Practical_20.Models;

namespace Practical_20.Interface
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; }
        Task<int> SaveAsync();
    }
}

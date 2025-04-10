using Practical_20.Data;
using Practical_20.Interface;
using Practical_20.Models;
using Practical_20.Repository_;

namespace Practical_20.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<User> _users;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<User> Users => _users ??= new GenericRepository<User>(_context);

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }

}

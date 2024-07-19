using Hng.Domain.Models;

namespace Hng.Infrastructure.Repository.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserById(Guid id);
    }
}
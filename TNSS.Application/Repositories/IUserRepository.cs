using TNSS.Domain.User;

namespace TNSS.Application.Repositories
{
    public interface IUserRepository
    {
        User GetUserByIdAsync(int id);
        IEnumerable<User> GetUsers();
    }
}
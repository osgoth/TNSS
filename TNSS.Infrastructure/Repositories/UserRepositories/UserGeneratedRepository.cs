using TNSS.Application.Repositories;
using TNSS.Domain.Enums;
using TNSS.Domain.User;

namespace TNSS.Infrastructure.Repositories.UserRepositories
{
    public class UserGeneratedRepository : IUserRepository
    {
        public User GetUserByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            var random = new Random();
            var firstNames = new string[] {"Josh", "James", "William", "Mary", "Jenny", "David", "Julia", "Annet"};
            var lastNames = new string[] {"Jameson", "Willow", "Greendow", "Smith", "Muller", "Greenfield", "Beerson"};
            var users = new List<User>();
            for (int i = 0; i < firstNames.Length * lastNames.Length; i++)
            {
                users.Add(new User()
                {
                    FullName = firstNames[random.Next(0, firstNames.Length-1)] + lastNames[random.Next(0, firstNames.Length-1)],
                    Id = random.Next(),
                    Number = random.Next(1000000, 9999999).ToString(),
                    UserStatus = UserStatus.Free,
                    BaseStationId = 1
                });
            }

            return users;
        }
    }
}
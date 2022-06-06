// using Microsoft.EntityFrameworkCore;
// using TNSS.Application.Repositories;
// using TNSS.Domain.User;
// using TNSS.Infrastructure.Contexts;
//
// namespace TNSS.Infrastructure.Repositories.UserRepositories
// {
//     public class UserDbRepository : IUserRepository
//     {
//         //TODO: for DI
//         private readonly TelecommunicationNetworkSimulatorContext _context;
//
//         //TODO: for DI
//         public UserRepository(TelecommunicationNetworkSimulatorContext context)
//         {
//             _context = context ?? throw new ArgumentNullException(nameof(context));
//         }
//
//         //TODO: remove after DI install
//         public UserRepository()
//         {
//             _context = new TelecommunicationNetworkSimulatorContext();
//         }
//
//         public async Task<User> GetUserByIdAsync(int id)
//         {
//             return await _context.Users.FirstOrDefaultAsync(_ => _.Id == id);
//         }
//
//         public async Task<IEnumerable<User>> GetUsers()
//         {
//             return await _context.Users.ToListAsync();
//         }
//     }
// }

// using Microsoft.EntityFrameworkCore;
// using TNSS.Application.Repositories;
// using TNSS.Domain.Constants;
// using TNSS.Infrastructure.Contexts;
//
// namespace TNSS.Infrastructure.Repositories.ConstantsRepositories
// {
//     public class ConstantsDbRepository : IConstantsRepository
//     {
//         //TODO: for DI
//         private readonly TelecommunicationNetworkSimulatorContext _context;
//
//         //TODO: for DI
//         public ConstantsRepository(TelecommunicationNetworkSimulatorContext context)
//         {
//             _context = context ?? throw new ArgumentNullException(nameof(context));
//         }
//
//         //TODO: remove after DI install
//         public ConstantsRepository()
//         {
//             _context = new TelecommunicationNetworkSimulatorContext();
//         }
//
//         public async Task<Constants> GetConstants()
//         {
//             return await _context.Constants.FirstOrDefaultAsync();
//         }
//     }
// }

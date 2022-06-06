// using Microsoft.EntityFrameworkCore;
// using TNSS.Application.Repositories;
// using TNSS.Domain.BaseStation;
// using TNSS.Infrastructure.Contexts;
//
// namespace TNSS.Infrastructure.Repositories.BaseStationRepositories
// {
//     public class BaseStationDbRepository : IBaseStationRepository
//     {
//         //TODO: for DI
//         private readonly TelecommunicationNetworkSimulatorContext _context;
//         
//         //TODO: for DI
//         public BaseStationDbRepository(TelecommunicationNetworkSimulatorContext context)
//         {
//             _context = context ?? throw new ArgumentNullException(nameof(context));
//         }
//
//         //TODO: remove after DI install
//         public BaseStationDbRepository()
//         {
//             _context = new TelecommunicationNetworkSimulatorContext();
//         }
//
//         public async Task<BaseStation> GetBaseStationByIdAsync(int id)
//         {
//             return await _context.BaseStations.FirstOrDefaultAsync(_ => _.Id == id);
//         }
//
//         public async Task<IEnumerable<BaseStation>> GetBaseStations()
//         {
//             return await _context.BaseStations.ToListAsync();
//         }
//     }
// }

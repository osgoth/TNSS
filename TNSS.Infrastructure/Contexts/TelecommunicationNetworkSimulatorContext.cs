// using Microsoft.EntityFrameworkCore;
// using TNSS.Application.Contexts;
// using TNSS.Domain.BaseStation;
// using TNSS.Domain.Constants;
// using TNSS.Domain.User;
//
// namespace TNSS.Infrastructure.Contexts
// {
//     public class TelecommunicationNetworkSimulatorContext : DbContext, ITelecommunicationNetworkSimulatorContext
//     {
//
//         public TelecommunicationNetworkSimulatorContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=TNS;Integrated Security=True;MultipleActiveResultSets=true")
//         { }
//
//         public DbSet<BaseStation> BaseStations { get; set; }
//         public DbSet<BaseStationLoad> BaseStationLoads { get; set; }
//         public DbSet<SubscriptionType> SubscriptionTypes { get; set; }
//         public DbSet<Constants> Constants { get; set; }
//         public DbSet<User> Users { get; set; }
//
//
//
//
//         public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
//         {
//             try
//             {
//                 await this.SaveChangesAsync(cancellationToken);
//             }
//             catch (DbEntityValidationException e)
//             {
//                 //need to Handle with some logger
//             }
//             catch (DbUpdateConcurrencyException e)
//             {
//                 //need to Handle with some logger
//             }
//             catch (Exception e)
//             {
//                 //need to Handle with some logger
//             }
//
//             return true;
//         }
//
//         protected override void OnModelCreating(DbModelBuilder modelBuilder)
//         {
//             base.OnModelCreating(modelBuilder);
//
//             // turn off pluralization
//             modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//
//         }
//
//     }
// }
//
//

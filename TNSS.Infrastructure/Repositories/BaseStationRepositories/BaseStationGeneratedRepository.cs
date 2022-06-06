using TNSS.Application.Repositories;
using TNSS.Domain.BaseStation;
using TNSS.Domain.Enums;

namespace TNSS.Infrastructure.Repositories.BaseStationRepositories
{
    public class BaseStationGeneratedRepository : IBaseStationRepository
    {
        public BaseStation GetBaseStationByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BaseStation> GetBaseStations()
        {
            var random = new Random();
            var baseStations = new List<BaseStation>();
            baseStations.Add(new BaseStation()
            {
                Capacity = 50,
                Id = 1,
                BaseStationStatusId = BaseStationStatus.IsRunning
            });

            return baseStations;
        }
    }
}
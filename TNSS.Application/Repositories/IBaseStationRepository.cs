using TNSS.Domain.BaseStation;

namespace TNSS.Application.Repositories
{
    public interface IBaseStationRepository
    {
        BaseStation GetBaseStationByIdAsync(int id);
        IEnumerable<BaseStation> GetBaseStations();
    }
}
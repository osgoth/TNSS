using TNSS.Domain.Enums;

namespace TNSS.Domain.BaseStation
{
    public class BaseStation
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public BaseStationStatus BaseStationStatusId { get; set; }
    }
}

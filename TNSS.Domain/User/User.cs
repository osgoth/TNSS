using TNSS.Domain.Enums;

namespace TNSS.Domain.User
{
    public class User
    {
        public int Id { get; set; }
        public int BaseStationId { get; set; }
        public int SubscriptionTypeId { get; set; }
        public int UserStatusId { get; set; }
        public int SecondsLeft { get; set; }
        public string FullName { get; set; }
        public string Number { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
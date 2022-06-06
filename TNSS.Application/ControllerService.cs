using TNSS.Application.Repositories;
using TNSS.Domain.BaseStation;
using TNSS.Domain.Constants;
using TNSS.Domain.User;

namespace TNSS.Application;

public class ControllerService
{
    private static IBaseStationRepository _baseStationRepository;
    private static IUserRepository _userRepository;
    private static IConstantsRepository _constantsRepository;
    
    // base station id to current capacity relation
    public Dictionary<int, int> baseStationCapacity = new Dictionary<int, int>();
    public List<BaseStation> BaseStations;
    public List<User> Users;
    public Constants Constants;

    public ControllerService(IBaseStationRepository baseStationRepository,
        IUserRepository userRepository, IConstantsRepository constantsRepository)
    {
        _baseStationRepository = baseStationRepository;
        _userRepository = userRepository;
        _constantsRepository = constantsRepository;

        BaseStations = _baseStationRepository.GetBaseStations().ToList();
        Users = _userRepository.GetUsers().ToList();
        Constants = _constantsRepository.GetConstants();
        
        var baseStations = baseStationRepository.GetBaseStations().ToList();
        foreach (var bs in baseStations)
        {
            baseStationCapacity.Add(bs.Id, 0);
        }
    }
}
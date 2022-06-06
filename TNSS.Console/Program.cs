using TNSS.Application;
using TNSS.Infrastructure.Repositories.BaseStationRepositories;
using TNSS.Infrastructure.Repositories.ConstantsRepositories;
using TNSS.Infrastructure.Repositories.UserRepositories;

var controllerService = new ControllerService(new BaseStationGeneratedRepository(), new UserGeneratedRepository(), new ConstantsGeneratedRepository());
UserLogic.StartUsers(controllerService);
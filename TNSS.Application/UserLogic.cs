using TNSS.Domain.Enums;
using TNSS.Domain.User;

namespace TNSS.Application;

public static class UserLogic
{
    public static void StartUsers(ControllerService controllerService)
    {
        List<Thread> threads = new List<Thread>();
        foreach (var user in controllerService.Users)
        {
            threads.Add(
                new Thread(
                    () => user.StartCalling(controllerService)
                )
            );
            threads.Last().Start();
        }
    }

    public static void StartCalling(this User user, ControllerService controllerService)
    {
        int chance = controllerService.Constants.UserCallChance; // in percents
        int callDelay = controllerService.Constants.CallDelay; // in seconds

        var rnd = new Random();

        while (true)
        {
            int chanceGenerated = rnd.Next(100);
            if (
                controllerService.BaseStations
                    .FirstOrDefault(bs => bs.Id == user.BaseStationId)!
                    .BaseStationStatusId == BaseStationStatus.IsRunning
            )
            {
                if (chanceGenerated > chance)
                {
                    Thread.Sleep(callDelay * 1000);
                }
                else
                {
                    User otherUser = controllerService.Users[rnd.Next(controllerService.Users.Count())];
                    if (otherUser.Id == user.Id)
                    {
                        continue;
                    }

                    user.Call(otherUser, controllerService);
                }
            }
        }
    }

    private static void Call(this User user, User otherUser, ControllerService controllerService)
    {
        var rnd = new Random();

        lock (otherUser)
        {
            if (otherUser.UserStatusId != 0)
            {
                return;
            }

            controllerService.baseStationCapacity[user.BaseStationId]++;
            controllerService.baseStationCapacity[otherUser.BaseStationId]++;
            user.UserStatusId = 1;
            otherUser.UserStatusId = 1;

            Console.WriteLine($@"++ {user.Number} -> {otherUser.Number}");
            Thread.Sleep(rnd.Next(1000, 3000));
            Console.WriteLine($@"-- {user.Number} -> {otherUser.Number}");

            controllerService.baseStationCapacity[user.BaseStationId]--;
            controllerService.baseStationCapacity[otherUser.BaseStationId]--;
            user.UserStatusId = 0;
            otherUser.UserStatusId = 0;
        }
    }
}
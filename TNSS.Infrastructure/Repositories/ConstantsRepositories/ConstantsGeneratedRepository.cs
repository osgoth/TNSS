using TNSS.Application.Repositories;
using TNSS.Domain.Constants;

namespace TNSS.Infrastructure.Repositories.ConstantsRepositories;

public class ConstantsGeneratedRepository : IConstantsRepository
{
    public Constants GetConstants()
    {
        return new Constants()
        {
            Id = 1,
            CallDelay = 60,
            UserCallChance = 30
        };
    }
}
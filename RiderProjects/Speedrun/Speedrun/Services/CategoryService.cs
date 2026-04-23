using Speedrun.Services.Interfaces;

namespace Speedrun.Services;

public class CategoryService(ISubgroupService subgroupService) : ICategoryService
{
    public void AddParticipantAndRecreateSubgroups(Guid newParticipantId, Guid categoryId)
    {
        _ = subgroupService;
        _ = newParticipantId;
        _ = categoryId;
        throw new NotImplementedException();
    }
}
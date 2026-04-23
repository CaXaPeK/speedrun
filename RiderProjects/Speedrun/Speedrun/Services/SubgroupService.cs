using Speedrun.Models.Database.Entities;
using Speedrun.Services.Interfaces;

namespace Speedrun.Services;

public class SubgroupService(IGridService gridService) : ISubgroupService
{
    public void CreateAllWithinCategory(List<CompetitionParticipant> participants, Guid categoryId)
    {
        _ = gridService;
        _ = participants;
        _ = categoryId;
        throw new NotImplementedException();
    }

    private List<List<CompetitionParticipant>> ShuffleParticipantsWithPriority(
        List<CompetitionParticipant> participants,
        int subgroupSize
    )
    {
        //сортируем чтобы все самые похожие были рядом
        
        //по одному закидываем в подгруппу по очереди
        
        return [];
    }

    public void DeleteAllWithinCategory(Guid categoryId)
    {
        _ = categoryId;
        throw new NotImplementedException();
    }
}
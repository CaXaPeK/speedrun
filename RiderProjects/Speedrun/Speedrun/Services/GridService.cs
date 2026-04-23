using Speedrun.Models.Database.Entities;
using Speedrun.Services.Interfaces;

namespace Speedrun.Services;

public class GridService : IGridService
{
    public Grid AssembleGrid(List<SubgroupParticipant> participants)
    {
        _ = participants;
        return new Grid();
    }

    private List<SubgroupParticipant> ShufflePairs(List<SubgroupParticipant> participants)
    {
        return [];
    }

    private int CalculatePairPenalty(CompetitionParticipant a, CompetitionParticipant b)
    {
        int penalty = 0;
        
        //если тренера совпадают
        var trainerIdsA = a.Sportsman.Trainers.Select(t => t.Id).ToHashSet();
        if (b.Sportsman.Trainers.Any(t => trainerIdsA.Contains(t.Id)))
        {
            penalty += 10;
        }
            
        //если клубы совпадают
        if (a.Sportsman.ClubId is not null
            && a.Sportsman.ClubId == b.Sportsman.ClubId)
        {
            penalty += 5;
        }
            
        //если города совпадают
        if (a.Sportsman.City == b.Sportsman.City)
        {
            penalty += 1;
        }

        return penalty;
    }
}
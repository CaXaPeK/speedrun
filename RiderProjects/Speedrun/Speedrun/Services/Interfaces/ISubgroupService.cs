using Speedrun.Models.Database.Entities;

namespace Speedrun.Services.Interfaces;

public interface ISubgroupService
{
    void CreateAllWithinCategory(List<CompetitionParticipant> participants, Guid categoryId);

    void DeleteAllWithinCategory(Guid categoryId);
}
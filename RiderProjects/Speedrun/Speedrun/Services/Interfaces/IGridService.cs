using Speedrun.Models.Database.Entities;

namespace Speedrun.Services.Interfaces;

public interface IGridService
{
    Grid AssembleGrid(List<SubgroupParticipant> participants);
}
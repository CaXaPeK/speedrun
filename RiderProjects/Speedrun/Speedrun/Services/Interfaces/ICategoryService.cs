namespace Speedrun.Services.Interfaces;

public interface ICategoryService
{
    void AddParticipantAndRecreateSubgroups(Guid newParticipantId, Guid categoryId);
}
using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class SubgroupMember
{
    [Key]
    public Guid Id { get; set; }
    public int Place { get; set; }

    public CompetitionParticipant Participant { get; set; } = null!;
    public Subgroup Subgroup { get; set; } = null!;
}
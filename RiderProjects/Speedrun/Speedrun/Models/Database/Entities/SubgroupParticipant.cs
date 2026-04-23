using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class SubgroupParticipant
{
    [Key]
    public Guid Id { get; set; }
    public int Place { get; set; }

    public int RatingPoints { get; set; }

    public Guid ParticipantId { get; set; }
    public CompetitionParticipant Participant { get; set; } = null!;

    public Guid SubgroupId { get; set; }
    public Subgroup Subgroup { get; set; } = null!;
}
using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class CompetitionParticipant
{
    [Key]
    public Guid Id { get; set; }

    public Guid SportsmanUserId { get; set; }
    public User Sportsman { get; set; } = null!;

    public Guid CompetitionId { get; set; }
    public Competition Competition { get; set; } = null!;

    public Guid? ApplicationEntryId { get; set; }
    public ApplicationEntry? ApplicationEntry { get; set; }

    public DateTime AddedAtUtc { get; set; } = DateTime.UtcNow;

    public ParticipantBracketSnapshot? BracketSnapshot { get; set; }
}
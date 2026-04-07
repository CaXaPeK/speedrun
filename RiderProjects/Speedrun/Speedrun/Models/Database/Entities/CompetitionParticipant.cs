using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class CompetitionParticipant
{
    [Key]
    public Guid Id { get; set; }

    public User Sportsman { get; set; } = null!;
    public Competition Competition { get; set; } = null!;
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}
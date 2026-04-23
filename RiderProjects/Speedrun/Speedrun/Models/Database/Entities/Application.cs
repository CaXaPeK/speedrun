using System.ComponentModel.DataAnnotations;
using Speedrun.Models.Enums;

namespace Speedrun.Models.Database.Entities;

/// <summary>Клубная заявка тренера на соревнование.</summary>
public class Application
{
    [Key]
    public Guid Id { get; set; }

    public Guid CompetitionId { get; set; }
    public Competition Competition { get; set; } = null!;

    public Guid SubmittedByUserId { get; set; }
    public User SubmittedBy { get; set; } = null!;

    public Guid? ClubId { get; set; }
    public Club? Club { get; set; }

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Draft;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAtUtc { get; set; }

    public ICollection<ApplicationEntry> Entries { get; set; } = new List<ApplicationEntry>();
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}

using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Competition
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDateUtc { get; set; }

    public string Location { get; set; } = null!;

    /// <summary>Токен/код приглашения для подачи заявок (опционально).</summary>
    public string? RegistrationInviteToken { get; set; }

    public Guid SportId { get; set; }
    public Sport Sport { get; set; } = null!;

    public Guid OrganizerUserId { get; set; }
    public User Organizer { get; set; } = null!;

    public ICollection<Venue> Venues { get; set; } = new List<Venue>();

    public ICollection<CompetitionCategory> Categories { get; set; } = new List<CompetitionCategory>();

    public ICollection<Application> Applications { get; set; } = new List<Application>();

    public ICollection<CompetitionParticipant> Participants { get; set; } = new List<CompetitionParticipant>();
}
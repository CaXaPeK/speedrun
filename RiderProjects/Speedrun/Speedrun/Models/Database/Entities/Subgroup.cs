using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Subgroup
{
    [Key]
    public Guid Id { get; set; }
    
    public int Number { get; set; }

    public Guid CompetitionCategoryId { get; set; }
    public CompetitionCategory CompetitionCategory { get; set; } = null!;

    public Guid VenueId { get; set; }
    public Venue Venue { get; set; } = null!;

    public Guid GridId { get; set; }
    public Grid Grid { get; set; } = null!;
    
    public ICollection<SubgroupParticipant> Participants { get; set; } = new List<SubgroupParticipant>();
    public ICollection<User> Secretaries { get; set; } = new List<User>();
}
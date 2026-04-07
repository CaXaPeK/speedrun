using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Match
{
    [Key]
    public Guid Id { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public Match? NextMatch { get; set; }
    public ICollection<MatchParticipant> Participants = new List<MatchParticipant>();
}
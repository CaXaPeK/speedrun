using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class MatchParticipant
{
    [Key]
    public Guid Id { get; set; }
    
    public bool IsWinner { get; set; }
    public int Number { get; set; }
    
    public SubgroupMember SubgroupMember { get; set; } = null!;
    public Match Match { get; set; } = null!;
}
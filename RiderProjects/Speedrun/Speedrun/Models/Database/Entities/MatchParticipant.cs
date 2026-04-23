using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class MatchParticipant
{
    [Key]
    public Guid Id { get; set; }
    
    public bool IsWinner { get; set; }

    public int Number { get; set; }

    public Guid SubgroupParticipantId { get; set; }
    public SubgroupParticipant SubgroupParticipant { get; set; } = null!;

    public Guid MatchId { get; set; }
    public Match Match { get; set; } = null!;
}
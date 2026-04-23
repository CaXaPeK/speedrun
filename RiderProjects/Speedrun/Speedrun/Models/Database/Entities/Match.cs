using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Match
{
    [Key]
    public Guid Id { get; set; }

    public Guid GridRoundId { get; set; }
    public GridRound GridRound { get; set; } = null!;

    public DateTime? StartTimeUtc { get; set; }
    public DateTime? EndTimeUtc { get; set; }

    public Guid? NextMatchIfWinId { get; set; }
    public Match? NextMatchIfWin { get; set; }

    public Guid? NextMatchIfLoseId { get; set; }
    public Match? NextMatchIfLose { get; set; }

    public ICollection<MatchParticipant> Participants { get; set; } = new List<MatchParticipant>();

    public ICollection<MatchEvent> Events { get; set; } = new List<MatchEvent>();
}
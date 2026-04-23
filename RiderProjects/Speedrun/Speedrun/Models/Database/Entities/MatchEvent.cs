using System.ComponentModel.DataAnnotations;
using Speedrun.Models.Enums;

namespace Speedrun.Models.Database.Entities;

public abstract class MatchEvent
{
    [Key]
    public Guid Id { get; set; }

    public Guid MatchId { get; set; }
    public Match Match { get; set; } = null!;

    public MatchEventKind Kind { get; set; }

    public DateTime OccurredAtUtc { get; set; } = DateTime.UtcNow;

    /// <summary>Смещение времени «в бою» (секунды) на момент события.</summary>
    public int? ElapsedInFightSeconds { get; set; }
}

public class MatchStartedEvent : MatchEvent;

public class MatchPausedEvent : MatchEvent
{
    public string? Reason { get; set; }
}

public class MatchResumedEvent : MatchEvent;

public class MatchEndedEvent : MatchEvent
{
    public string? Reason { get; set; }
}

public class ScoreRecordedEvent : MatchEvent
{
    public Guid JudgementTypeId { get; set; }
    public JudgementType JudgementType { get; set; } = null!;

    /// <summary>Номер участника в матче (1 или 2 и т.д.).</summary>
    public int TargetParticipantNumber { get; set; }
}

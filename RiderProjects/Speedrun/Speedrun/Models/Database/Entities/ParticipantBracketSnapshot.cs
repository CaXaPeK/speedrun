using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

/// <summary>Снимок данных участника на момент фиксации в зачёт (для штрафов и сеток).</summary>
public class ParticipantBracketSnapshot
{
    [Key]
    public Guid Id { get; set; }

    public Guid CompetitionParticipantId { get; set; }
    public CompetitionParticipant CompetitionParticipant { get; set; } = null!;

    public DateTime CapturedAtUtc { get; set; } = DateTime.UtcNow;

    public string City { get; set; } = null!;

    public Guid? ClubId { get; set; }
    public Club? Club { get; set; }

    /// <summary>JSON-массив Guid тренеров (User.Id).</summary>
    public string TrainerUserIdsJson { get; set; } = "[]";
}

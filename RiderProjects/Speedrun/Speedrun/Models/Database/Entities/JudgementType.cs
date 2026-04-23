using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class JudgementType
{
    [Key]
    public Guid Id { get; set; }

    public Guid DisciplineId { get; set; }
    public Discipline Discipline { get; set; } = null!;

    public string Name { get; set; } = null!;

    public double Cost { get; set; }

    public bool IsNegative { get; set; }

    public bool IsConclusive { get; set; }
}
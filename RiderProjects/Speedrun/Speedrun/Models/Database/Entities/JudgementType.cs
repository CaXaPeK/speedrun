using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class JudgementType
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public double Cost { get; set; }
    public bool IsNegative { get; set; } = false;
    public bool IsConclusive { get; set; } = false;
}
using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Discipline
{
    [Key]
    public Guid Id { get; set; }

    public Guid SportId { get; set; }
    public Sport Sport { get; set; } = null!;

    public string Name { get; set; } = null!;

    public ICollection<JudgementType> JudgementTypes { get; set; } = new List<JudgementType>();

    public ICollection<Feature> Features { get; set; } = new List<Feature>();
}
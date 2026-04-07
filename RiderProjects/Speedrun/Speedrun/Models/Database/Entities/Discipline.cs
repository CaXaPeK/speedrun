using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Discipline
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public ICollection<JudgementType> JudgementTypes = new List<JudgementType>();
    public ICollection<Feature> Features = new List<Feature>();
}
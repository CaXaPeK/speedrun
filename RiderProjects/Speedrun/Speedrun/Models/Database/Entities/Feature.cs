using System.ComponentModel.DataAnnotations;
using Speedrun.Models.Enums;

namespace Speedrun.Models.Database.Entities;

public class Feature
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public Discipline? RelatedDiscipline { get; set; }
    public Sport? RelatedSport { get; set; }
    public double? MinValue { get; set; }
    public double? MaxValue { get; set; }
    public ICollection<string> AllowedValues = new List<string>();
    public FeatureDataType DataType { get; set; }
}
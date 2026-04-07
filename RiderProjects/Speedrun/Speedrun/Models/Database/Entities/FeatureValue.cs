namespace Speedrun.Models.Database.Entities;

public class FeatureValue
{
    public Guid Id { get; set; }

    public string Value { get; set; } = null!;

    public Feature Feature { get; set; } = null!;
}
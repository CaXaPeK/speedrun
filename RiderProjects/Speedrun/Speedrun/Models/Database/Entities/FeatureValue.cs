using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class FeatureValue
{
    [Key]
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }

    public string Value { get; set; } = null!;

    public Guid FeatureId { get; set; }
    public Feature Feature { get; set; } = null!;
}
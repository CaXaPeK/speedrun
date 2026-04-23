using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class ApplicationEntryFeatureValue
{
    [Key]
    public Guid Id { get; set; }

    public Guid ApplicationEntryId { get; set; }
    public ApplicationEntry ApplicationEntry { get; set; } = null!;

    public Guid FeatureId { get; set; }
    public Feature Feature { get; set; } = null!;

    public string Value { get; set; } = null!;
}

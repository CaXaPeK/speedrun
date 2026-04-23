using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

/// <summary>Одна строка заявки: один спортсмен.</summary>
public class ApplicationEntry
{
    [Key]
    public Guid Id { get; set; }

    public Guid ApplicationId { get; set; }
    public Application Application { get; set; } = null!;

    public Guid SportsmanUserId { get; set; }
    public User Sportsman { get; set; } = null!;

    public ICollection<ApplicationEntryFeatureValue> FeatureValues { get; set; } = new List<ApplicationEntryFeatureValue>();
}

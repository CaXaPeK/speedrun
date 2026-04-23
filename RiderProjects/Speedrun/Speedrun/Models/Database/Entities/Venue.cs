using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

/// <summary>Площадка (корт, татами) в рамках соревнования.</summary>
public class Venue
{
    [Key]
    public Guid Id { get; set; }

    public Guid CompetitionId { get; set; }
    public Competition Competition { get; set; } = null!;

    public int Number { get; set; }

    public string? DisplayName { get; set; }

    public ICollection<Subgroup> Subgroups { get; set; } = new List<Subgroup>();
}

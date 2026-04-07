using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public abstract class SelectionCriterion
{
    [Key]
    public Guid Id { get; set; }

    public Feature Feature { get; set; } = null!;
}
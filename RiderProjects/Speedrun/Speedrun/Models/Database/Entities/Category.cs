using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Category
{
    [Key]
    public Guid Id;

    public Discipline Discipline { get; set; } = null!;

    public ICollection<SelectionCriterion> SelectionCriteria = new List<SelectionCriterion>();
    
    public int MatchDuration { get; set; }
}
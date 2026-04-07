using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class CompetitionCategory
{
    [Key]
    public Guid Id { get; set; }
    
    public Category Category { get; set; } = null!;
    public ICollection<Subgroup> Subgroups = new List<Subgroup>();
}
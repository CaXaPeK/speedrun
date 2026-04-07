using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Subgroup
{
    [Key]
    public Guid Id { get; set; }
    
    public int Number { get; set; }
    public Field Field { get; set; } = null!;
    public Grid Grid { get; set; } = null!;
    
    public ICollection<SubgroupMember> Members { get; set; } = new List<SubgroupMember>();
    public ICollection<User> Secretaries { get; set; } = new List<User>();
}
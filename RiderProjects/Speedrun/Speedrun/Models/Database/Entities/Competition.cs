using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Competition
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; } = null!;
    public Sport Sport { get; set; } = null!;
    public User Organizer { get; set; } = null!;
    public ICollection<Field> Fields = new List<Field>();
}
using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Sport
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; } = null!;
    
    public ICollection<Discipline> Disciplines = new List<Discipline>();
    public ICollection<Feature> Features = new List<Feature>();
}
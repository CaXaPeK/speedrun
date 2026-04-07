using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Subgroup
{
    [Key]
    public Guid Id { get; set; }
    
    public int Number { get; set; }
    public Field Field { get; set; } = null!;
}
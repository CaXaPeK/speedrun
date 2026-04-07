using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Field
{
    [Key]
    public Guid Id { get; set; }
    
    public int Number { get; set; }
}
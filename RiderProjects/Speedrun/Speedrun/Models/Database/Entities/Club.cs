using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Club
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<User> Members { get; set; } = new List<User>();

    public ICollection<User> Administrators { get; set; } = new List<User>();
}
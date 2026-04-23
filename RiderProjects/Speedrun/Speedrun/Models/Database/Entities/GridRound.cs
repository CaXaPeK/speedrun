using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class GridRound
{
    [Key]
    public Guid Id { get; set; }

    public Guid GridId { get; set; }
    public Grid Grid { get; set; } = null!;

    public int Order { get; set; }

    public ICollection<Match> Matches { get; set; } = new List<Match>();
}
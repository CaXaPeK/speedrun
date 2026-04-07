using System.ComponentModel.DataAnnotations;

namespace Speedrun.Models.Database.Entities;

public class Grid
{
    [Key]
    public Guid Id { get; set; }

    public ICollection<GridRound> Rounds { get; set; } = new List<GridRound>();
}
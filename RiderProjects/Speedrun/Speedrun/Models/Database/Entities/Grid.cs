using System.ComponentModel.DataAnnotations;
using Speedrun.Models.Enums;

namespace Speedrun.Models.Database.Entities;

public class Grid
{
    [Key]
    public Guid Id { get; set; }

    public GridKind Kind { get; set; } = GridKind.Elimination;

    public ICollection<GridRound> Rounds { get; set; } = new List<GridRound>();
}
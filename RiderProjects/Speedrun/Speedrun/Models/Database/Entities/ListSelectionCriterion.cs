namespace Speedrun.Models.Database.Entities;

public class ListSelectionCriterion : SelectionCriterion
{
    public ICollection<string> AcceptableValues = new List<string>();
}
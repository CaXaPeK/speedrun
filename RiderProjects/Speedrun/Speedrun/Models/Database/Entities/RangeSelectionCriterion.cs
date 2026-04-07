namespace Speedrun.Models.Database.Entities;

public class RangeSelectionCriterion : SelectionCriterion
{
    public double LowerLimit { get; set; }
    public bool IsLowerLimitIncluding { get; set; } = true;
    public double UpperLimit { get; set; }
    public bool IsUpperLimitIncluding { get; set; } = true;
}
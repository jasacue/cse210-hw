public class EternalGoal : Goal
{
    private int _completions;

    public EternalGoal(int value, string goalName, string description)
        :base(value, goalName, description)
    {
        _value = value;
        _goalName = goalName;
        _completions = 0;
        _description = description;
    }
    public override string GetCompletion()
    {
        return " ";
    }
    public override void Complete()
    {
        _completions ++;
    }
}
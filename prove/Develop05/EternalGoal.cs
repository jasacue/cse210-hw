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
    public EternalGoal(int value, string goalName, string description, int completions)
        :base(value, goalName, description)
    {
        _value = value;
        _goalName = goalName;
        _completions = completions;
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
    public override string CompressData()
    {
        return $"EternalGoal,{_value},{_goalName},{_description},{_completion},{_completions}";
    }
}
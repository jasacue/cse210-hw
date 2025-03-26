public class ListGoal : Goal
{
    private int _incrementPointVal;
    private int _completions;
    private int _neededCompletions;

    public ListGoal(int value, string goalName, string description, int incrementPointVal, int neededCompletions)
        :base (value, goalName, description)
        {
            _value = value;
            _goalName = goalName;
            _incrementPointVal = incrementPointVal;
            _completions = 0;
            _neededCompletions = neededCompletions;
        }
    public ListGoal(int value, string goalName, string description, string completion, int incrementPointVal,int completions, int neededCompletions)
        :base (value, goalName, description)
        {
            _value = value;
            _goalName = goalName;
            _incrementPointVal = incrementPointVal;
            _completion = completion;
            _completions = completions;
            _neededCompletions = neededCompletions;
        }
    public override string GetCompletion()
    {
        return $"{_completions}/{_neededCompletions}";
    }

    public override void Complete()
    {
        _completions ++;
        if (_completions == _neededCompletions)
        {
            _completion = "true";
        }
    }
    public override string CompressData()
    {
        return $"ListGoal,{_value},{_goalName},{_description},{_completion},{_incrementPointVal},{_completions},{_neededCompletions}";
    }
}
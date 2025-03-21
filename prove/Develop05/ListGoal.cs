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
    public override string GetCompletion()
    {
        return $"{_completions}/{_neededCompletions}";
    }

    public override void Complete()
    {
        _completions ++;
    }

}
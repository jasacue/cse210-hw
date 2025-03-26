public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(int value, string goalName, string description)
        :base(value, goalName, description)
        {
            _value = value;
            _goalName = goalName;
            _isComplete = false;
            _description = description;
        }
    public SimpleGoal(int value, string goalName, string description, string isComplete)
        :base(value, goalName, description)
        {
            _value = value;
            _goalName = goalName;
            if (isComplete =="True")
            {
                _isComplete = true;
            }
            else
            {
                _isComplete = false;
            }
            _description = description;
        }
    public override string GetCompletion()
    {
        if (_isComplete)
        {
            return "X";
        }
        else
        {
            return " ";
        }
        
    }
    public override void Complete()
    {
        _isComplete = true;
    }
    public override string CompressData()
    {
        return $"SimpleGoal,{_value},{_goalName},{_description},{_completion},{_isComplete}";
    }
}
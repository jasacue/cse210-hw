public class Goal
{
    protected int _value;

    protected string _goalName;

    protected string _description;

    protected string _completion;

    public Goal(int value, string goalName, string description)
    {
        _value = value;
        _goalName = goalName;
        _description = description;

    }

    public string GetName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public virtual string GetCompletion()
    {
        
        return "";
    }
    public virtual void Complete()
    {
        _completion = "true";
    }
}
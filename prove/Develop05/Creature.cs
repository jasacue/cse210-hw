using System.Security.Cryptography.X509Certificates;

public class Creature
{
    public string _name;

    public int _level;
    
    public int _goalPoints;

    public int _goalsCompleted;

    public List<Goal> _goals = new List<Goal>();

    public Creature(string name)
    {
        _name = name;
        _level = 1;
        _goalPoints = 0;
        _goalsCompleted = 0;
        
    }

    public Creature(string name, int level, int goalPoints, int goalsCompleted)
    {
        _name = name;
        _level = level;
        _goalPoints = goalPoints;
        _goalsCompleted = goalsCompleted;
    }

    public void DisplayComplete()
    {
        int i = 0;
        while (i != _goals.Count())
        {
            Console.WriteLine($"[{_goals[i].GetCompletion()}]--{_goals[i].GetName()}");
            i +=1;
        }
    }

    public void DisplayNames()
    {
        int i = 0;
        while (i != _goals.Count())
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
            i +=1;
        }
    }
}
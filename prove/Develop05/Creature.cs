using System.Security.Cryptography.X509Certificates;

public class Creature
{
    public string _name;

    public int _level;
    
    public int _totalPoints;

    public int _goalsCompleted;

    public List<Goal> _goals = new List<Goal>();

    public Creature(string name)
    {
        _name = name;
        _level = 1;
        _totalPoints = 0;
        _goalsCompleted = 0;
        
    }
    
    public Creature(string name, int level, int totalPoints, int goalsCompleted)
    {
        _name = name;
        _level = level;
        _totalPoints = totalPoints;
        _goalsCompleted = goalsCompleted;
    }

    public void GoalCompleted(int points)
    {
        _goalsCompleted ++;
        _totalPoints += points;
    }

    public void PointsUp(int points)
    {
        _totalPoints += points;
    }

    public void GetLevel()
    {
        _level = (_totalPoints/500)+1;
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

    public void SaveCreature(string fileName)
    {
        

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_name},{_totalPoints},{_goalsCompleted}");
            foreach (var g in _goals)
            {
                outputFile.WriteLine($"{g.CompressData()}");
            }
        }
    }

    public void LoadCreature(string fileName)
    {
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] basic = lines[0].Split(",");
        _totalPoints = Convert.ToInt32(basic[1]);
        _name = basic[0];
        _goalsCompleted = Convert.ToInt32(basic[2]);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            switch (parts[0])
            {
                case "SimpleGoal":
                {
                    SimpleGoal s = new SimpleGoal(Convert.ToInt32(parts[1]),parts[2],parts[3],parts[4]);
                    _goals.Add(s);
                    break;
                }
                case "EternalGoal":
                {
                    EternalGoal s = new EternalGoal(Convert.ToInt32(parts[1]),parts[2],parts[3],Convert.ToInt32(parts[5]));
                    _goals.Add(s);
                    break;
                }
                case "ListGoal":
                {
                    ListGoal s = new ListGoal(Convert.ToInt32(parts[1]),parts[2],parts[3],parts[4],Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]),Convert.ToInt32(parts[7]));
                    _goals.Add(s);
                    break;
                }   
            }
        }


    }
}  
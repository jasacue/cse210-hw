using System;

public class Creature
{
    public string _name;

    public int _level;
    
    public int _goalPoints;

    public int _goalsCompleted;

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


}




public class Goal
{
    protected int _value;

    protected string _goalName;

    protected string _description;

    public Goal(int value, string goalName, string description)
    {
        _value = value;
        _goalName = goalName;
        _description = description;

    }
}

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
    public void completed()
    {
        _isComplete = true;
    }
}

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

    public void complete()
    {
        _completions ++;
    }
}

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


        
}





class Program
{



    static void Main(string[] args)
    {
        /*main menu*/
        int i = 10;
        Console.WriteLine("Welcome to the goal setting program\nPlease Select what you would like to do:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event");
        i = Convert.ToInt32(Console.ReadLine());
        while (i != 0)
        {
            switch (i)
            {
                case 1:
                {
                    int z;
                    Console.WriteLine("What type of goal would you like to make? \n1. Simple Goal \n2. Eternal Goal\n3. List Goal");
                    z = Convert.ToInt32(Console.ReadLine());
                    string description = "";
                    int value;
                    string goalName = "";
                    switch (z)
                    {
                        case 1:
                        {
                            Console.Write("Please Enter the Name of the goal: ");
                            goalName = Console.ReadLine();
                            Comnsole.Write("Please Enter a Short Description: ");
                            description = Console.ReadLine();
                            Console.Write("Please Enter the Value of the goal: ");
                            value = Convert.ToInt32(Console.ReadLine());
                            SimpleGoal s = new SimpleGoal(value, goalName, description);
                        }
                    }
                    break;
                }
                case 2:
                {
                    break;
                }

            }
            i = Convert.ToInt32(Console.ReadLine());
        }
    }
}
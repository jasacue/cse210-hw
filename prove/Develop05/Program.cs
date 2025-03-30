using System;

class Program
{



    static void Main(string[] args)
    {
        /*main menu*/
        Creature pet = new Creature("steve");
        int i = 10;
        Console.WriteLine("Welcome to the goal setting program\nPlease Select what you would like to do:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Make Creature\n7. Check Creature\n0. Quit");
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
                        case 1: /*simple goal */
                        {
                            Console.Write("Please Enter the Name of the goal: ");
                            goalName = Console.ReadLine();
                            Console.Write("Please Enter a Short Description: ");
                            description = Console.ReadLine();
                            Console.Write("Please Enter the Value of the goal: ");
                            value = Convert.ToInt32(Console.ReadLine());
                            SimpleGoal s = new SimpleGoal(value, goalName, description);
                            pet._goals.Add(s);
                            break;
                        }
                        case 2: /*eternal goal*/
                        {   
                            Console.Write("Please Enter the Name of the goal: ");
                            goalName = Console.ReadLine();
                            Console.Write("Please Enter a Short Description: ");
                            description = Console.ReadLine();
                            Console.Write("Please Enter the Value of the goal: ");
                            value = Convert.ToInt32(Console.ReadLine());
                            EternalGoal s = new EternalGoal(value, goalName, description);
                            pet._goals.Add(s);
                            break;
                        }
                        case 3: /*checklist Goal */
                        {
                            Console.Write("Please Enter the Name of the goal: ");
                            goalName = Console.ReadLine();
                            Console.Write("Please Enter a Short Description: ");
                            description = Console.ReadLine();
                            Console.Write("Please Enter the Value of the goal: ");
                            value = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the incremental point value: ");
                            int increment = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the needed completions: ");
                            int needed = Convert.ToInt32(Console.ReadLine());
                            ListGoal s = new ListGoal(value, goalName, description, increment, needed);
                            pet._goals.Add(s);
                            break;
                        }
                    }
                    break;
                }

                case 2:
                {
                    pet.DisplayComplete();
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    break;
                }
                case 3:
                {
                    Console.Write("Enter file name to save too: ");
                    string fileName = Console.ReadLine();
                    pet.SaveCreature(fileName);
                    break;
                }
                case 4:
                {
                    Console.Write("Enter file name to load from: ");
                    string fileName = Console.ReadLine();
                    pet.LoadCreature(fileName);
                    break;
                }
                case 5: //points up
                {
                    Console.WriteLine("Which Goal did you accomplish? ");
                    pet.DisplayNames();
                    int p = Convert.ToInt32(Console.ReadLine());
                    pet._goals[p-1].Complete();
                    pet._totalPoints += pet._goals[p-1].GetValue();
                    break;
                }
                case 6: //make a new creature
                {   
                    Console.WriteLine("What would you like to name the creature?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What kind of creature is it?");
                    string type = Console.ReadLine();
                    pet.NameType(name, type);
                    break;
                }
                case 7: //check on the creature
                {
                    pet.DisplayCreature();
                    break;
                }


            }
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Make Creature\n7. Check Creature\n0. Quit");
            i = Convert.ToInt32(Console.ReadLine());
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        int fav_num = 0;
        int squared = 0;
        DisplayMessage();
        name = GetName(name);
        fav_num = FavoriteNumber(fav_num);
        squared = Square(fav_num);
        DisplayResult(name, squared);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program.");
        }

        static string GetName(string name)
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            return name;
        }
        static int FavoriteNumber(int fav_num)
        {
            Console.WriteLine("What is your favorite number?");
            return Int32.Parse(Console.ReadLine());
        }
        static int Square(int fav_num)
        {
            return fav_num*fav_num;
        }
        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, your number squared is {squared}");
        }

    }
}
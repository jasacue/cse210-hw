using System;

class Program
{
    static void Main(string[] args)
    {
        int entry = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Please enter yor numbers: ");
        while (entry != 0)
        {
            entry = Convert.ToInt32(Console.ReadLine());
            numbers.Add(entry);
        }
        int total = 0;
        foreach (int item in numbers)
        {
            total = total+item;
            
        }
        Console.WriteLine($"total is {total}");
        Console.WriteLine($"average is {total/(numbers.Count)}");
        Console.WriteLine($"The largest number was {numbers.Max()}");
    }
}
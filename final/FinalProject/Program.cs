using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to medication tracker");
        Console.WriteLine("Add a medication:\nWhat is the name of the medication?");
        string name = Console.ReadLine();
        Console.WriteLine("What is the purpose of the medication?");
        string purpose = Console.ReadLine();
        Console.WriteLine("What is the dosage of medication?(int)");
        int dosage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the unti? (ex. Pills, ml, ounces)");
        string unit = Console.ReadLine();
        Medication m = new Medication(name, purpose, dosage, unit);
    }
}
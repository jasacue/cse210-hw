using System;
using System.Security.Cryptography.X509Certificates;



class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractonString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractonString());
        Console.WriteLine(f2.GetDecimalValue());
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractonString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}
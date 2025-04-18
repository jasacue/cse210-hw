using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;


class Program
{
    static void Main(string[] args)
    {
        Scripture John = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference J = new Reference("john", "3", "16");
        string quit = "";
        John.Split();
        Console.Clear();
        John.WriteScripture();
        Console.WriteLine("\nPress Enter to Start");
        Console.ReadLine();
        while (quit != "quit")
        {
            Console.Clear();
            John.HideNew();
            Console.WriteLine($"{J.GetReference()} ");
            John.WriteScripture();
            if (John.AllHidden())
            {
                Console.WriteLine("\nScripture is fully hidden");
                quit = "quit";
            }
            else
            {
            Console.WriteLine("\nPress Enter to Continue, type \"quit\" to quit");
            quit = Console.ReadLine();
            }
        }
        Console.WriteLine("Thanks for using my scripture memeorizer.");
    }
}

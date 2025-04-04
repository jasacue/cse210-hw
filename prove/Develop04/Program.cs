using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
class Program
{






    static void Main(string[] args)
    {
        /*menu*/
        string quit = "";
        while (quit != "quit")
        {
            Console.WriteLine("Welcome to the Mindfullness Activity Launcher");
            Console.WriteLine("1. Breathing Activity \n2. Reflection Activity \n3. Listing Activity \n4. Quit ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                BreathingActivity breathe = new BreathingActivity("des", "name", "end", 0);
                breathe.BreathActive();
                break;

                case 2:
                ReflectionActivity reflect = new ReflectionActivity("", "", "", 0);
                reflect.RefActive();
                break;

                case 3:
                ListingActivity lis = new ListingActivity("", "", "", 0);
                lis.ListActive();
                break;

                case 4:
                Console.WriteLine("Goodbye");
                quit = "quit";
                break;
            }
        }
    }
}
using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.IO;

class Program
{
    static void Menu(Journal new_journal) 
    {   
        string filename = "";
        int i=0;
        while (i != 5)
        {
        
        /*displays menu*/
        Console.Write("What would you like to do?\n1. Write Entry\n2. Display Entry\n3. Load File\n4. Save Entries to File\n5. Quit Program\n>");
        i = Int32.Parse(Console.ReadLine());
     
        switch(i)
        {
        case 1: /* makes new entry */
            new_journal.NewEntry();
            break;
        case 2:
            new_journal.DisplayEntries();
            break;
        case 3: /*loads file*/
            Console.Write("Please enter the name of the file you want to load: ");
            filename = Console.ReadLine();
            new_journal.LoadEntries(filename, new_journal);
            break;
        case 4: /*saves unsaved entries to a file */
            Console.Write("Please enter the name of the file you want to save to: ");
            filename = Console.ReadLine();
            new_journal.SaveEntries(filename);
            break;
        case 5:

            break;
        default:
            Console.Write("Not a menu option.");
            break;
        }
        
        }
    }
    static void Main(string[] args)
    {   
        Journal new_journal = new Journal();
        Menu(new_journal);
        
    }
}


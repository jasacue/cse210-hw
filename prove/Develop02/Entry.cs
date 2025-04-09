using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.IO;

public class Entry {
    public string _entry;
    public string _date;
    public string _prompt;
    public string _location;
    


    public Entry(string entry, string date, string prompt, string location)
    {
        _entry = entry;
        _date = date;
        _prompt = prompt;
        _location = location;
    }
    public Entry()
    {
        
    }

    public string GivePrompt() /*returns a random journal prompt from a switch statement which is then displayed to the user */
    {   
        string choice="";
        Random rnd = new Random();
        int randnum= 0;
        randnum = rnd.Next(1,6);
        switch(randnum){
            case 1:
            choice = "Write about a class you had today: ";
            break;

            case 2:
            choice = "Write about your faveorite animal: ";
            break;

            case 3:
            choice = "Write about your faveorite state: ";
            break;

            case 4:
            choice = "Write about how much you love your mom: ";
            break;

            case 5:
            choice = "Write about your the best song you've ever heard: ";
            break; 
        }
        return choice;
    }   
    public string GetEntry()
    {
        string entry = "";
        Console.Write("Entry:");
        entry = Console.ReadLine();
        return entry;
    }
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        return date;
    }
    public string GetLocation()  /*Bonus Requirement*/
    {
        string location = "";
        Console.Write("Please Enter your locaiton:");
        location = Console.ReadLine();
        return location;
    }


}
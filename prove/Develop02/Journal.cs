using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Transactions;
public class Journal{
    public Entry _currentEntry = new Entry();
    public List<Entry> _unsavedEntries = new List<Entry>();

    public void SaveEntries(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _unsavedEntries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._entry},{entry._location}");
            }

        }
        Console.WriteLine("Saved!");
    }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _unsavedEntries)
        {
            Console.WriteLine($"{Condense(entry)}\n");
        }
    }
    public void NewEntry()
    {   
        string prompt = _currentEntry.GivePrompt();
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();
        Entry e = new Entry(entry, _currentEntry.GetDate(), prompt, _currentEntry.GetLocation());
        _unsavedEntries.Add(e);
        
    }
    public string Condense(Entry entry)
    {
        string condensed;
        condensed = $"Date: {entry._date} - Location: {entry._location} - Prompt: {entry._prompt} {entry._entry}";
        return condensed;
    }

    public Entry LoadEntries(string filename, Journal journal)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string lin in lines)
        {
            string[] line =lin.Split(',');
            Entry e = new Entry(line[3], line[0], line[2], line[1]);
            journal._unsavedEntries.Add(e);
        }
        return null;
    }

}
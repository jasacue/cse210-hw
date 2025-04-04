using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.IO;
public class Journal{
    public Entry _currentEntry;
    public List<string> _unsavedEntries;

    public void _SaveEntries(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (string entry in _unsavedEntries)
            {
                outputFile.WriteLine(entry);
            }

        }
        Console.WriteLine("Saved!");
    }
    
    public void _DisplayEntries()
    {
        foreach (string entry in _unsavedEntries)
        {
            Console.WriteLine($"{entry}\n");
        }
    }
    public Entry _NewEntry(Entry entry1)
    {
        entry1._prompt = entry1._GivePrompt();
        entry1._date = entry1._GetDate();
        entry1._location = entry1._GetLocation();
        Console.WriteLine($"Prompt: {entry1._prompt}"); 
        entry1._entry = entry1._GetEntry();
        return entry1;
    }
    public string _Condense(Entry entry)
    {
        string condensed;
        condensed = $"Date: {entry._date} - Location: {entry._location} - Prompt: {entry._prompt} {entry._entry}";
        return condensed;
    }

    public Entry _LoadEntries(string filename, Journal journal)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            journal._unsavedEntries.Add(line);
        }
        return null;
    }

}
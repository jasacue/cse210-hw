using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Word
{
    private List<string> _hiddenWords;
    
    public void _replaceWithUnderscore(List<string> list)
    {
        Random r = new Random();
        int ind = list.Count()-1;
        foreach (var word in list)
        {
            int rand = r.Next(0, ind);
            Console.WriteLine(list[rand]);
            if (list[rand] == null){
                Console.Write("broken");
            }
            if (list[rand].IndexOf("_") != -1)
            {
                continue;
            }
            else
            {
                string underscore = "";
                int i = 0;
                int len = list[rand].Length;
                while (i != len)
                {
                    underscore += '_';
                    i += 1;
                }
                list[rand] = underscore;
                break;
            }
            
        }
        _hiddenWords= list;
    }


}

public class Scripture
{
    private string _text;
    private List<string> _words;
    

    public void _rejoin(List<string> old)
    {
        string joined ="";
        foreach (var l in old)
        {
            joined += $"{l} ";
        }
        _text = joined;
    }
    public void _writeScripture(string re)
    {
        /*Console.Clear();*/
        Console.WriteLine(re);
        Console.WriteLine(_text);
    }
    public void _split(string scrip)
    {
        List<string> newScrip = new List<string>();
        string[] words = scrip.Split(" ");
        foreach (var word in words)
        {
            newScrip.Add(word);
        }
        _words= newScrip;
    }
}

class Reference
{
    public string _full;
    public string _book;
    public string _chapter;
    public string _startVerse;
    public string _endVerse;
    public void _condense()
    {
        string refer = "";
        if (_startVerse == _endVerse)
        {
            refer = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            refer = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        
        _full= refer;
    }
    public void _setReference()
    {
        _book = "John";
        _chapter = "3";
        _startVerse = "16";
        _endVerse = "16";
    }
}







class Program
{
    static void Main(string[] args)
    {
        Scripture john = new Scripture();
        Word hide = new Word();
        Reference re = new Reference();
        john._text = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have eternal life";
        string cont = "";
        while (cont != "quit")
        {
        john._split(john._text);
        hide._replaceWithUnderscore(john._words);
        john._rejoin(hide._hiddenWords);
        john._writeScripture(re._full);
        Console.WriteLine("Press Enter to Continue, Type \"quit\" to quit");
        cont = Console.ReadLine();
        }
        

    }
}

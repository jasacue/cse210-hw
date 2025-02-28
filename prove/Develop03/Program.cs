using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Word
{
    private string _word;
    private string _wordHidden;
    private bool _isHidden;

    public Word()
    {

    }
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void HideWord()
    {
        _isHidden = true;
        int len = _word.Length;
        int i = 0;
        while (i != len)
        {
            _wordHidden += "_";
            i ++;
        }
    }

    public void RevealWord()
    {
        _isHidden = false;
    }

    public string GetWord()
    {
        return _word;
    }
    
    public bool CheckHidden()
    {
        return _isHidden;
    }
    public string GetWordHidden()
    {
        return _wordHidden;
    }

}

public class Scripture
{
    private string _text;
    private List<Word> _words;
    
    private bool _isAllHidden;

    public Scripture(string text)
    {
        _text = text;
        List<Word> temp = new List<Word>();
        _words = temp;

        
    }

    public void WriteScripture()
    {
        int w = 0;
        int i = 0;
        while (w != _words.Count())
        {
            if (_words[w].CheckHidden())
            {
                Console.Write($"{_words[w].GetWordHidden()} ");
                w +=1;
                i ++;
            }
            else
            {
                Console.Write($"{_words[w].GetWord()} ");
                w +=1;
            }
        }
        if (i == _words.Count())
        {
            Console.Clear();
            Console.WriteLine("Scripture Fully Hidden!");
            
        }
    }

    public void Split()
    {
        string[] words = _text.Split(" ");
        foreach (var word in words)
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
        }
    }

    public List<Word> GetWords()
    {
        return _words;
    }
    public string GetText()
    {
        return _text;
    }
    public void HideNew()
    {
        Random r = new Random();
        int c;
        int i =0;
        bool done = false;
        int len = _words.Count();
        while(done != true)
        {
            c = r.Next(0, len);
            if(_words[c].CheckHidden())
            {
                i += 1;
                continue;
            }
            else if (!_words[c].CheckHidden())
            {
                _words[c].HideWord();
                done = true;
            }
            else
            {
                _isAllHidden = true;
            }   
        }
        
    }
    public bool AllHidden()
    {
        return _isAllHidden;
    }
}

class Reference
{
    private string _full;
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _condense();
    }
    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _condense();
    }
    public void _condense()
    {
        string refer;
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


    public string getReference()
    {
        return $"{_full}";
    }
}







class Program
{
    static void Main(string[] args)
    {
        Scripture John = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference J = new Reference("john", "3", "16");
        Console.WriteLine("Scripture Memorizer");
        string quit = "";
        John.Split();
        while (quit != "quit")
        {
            Console.Clear();
            John.HideNew();
            Console.WriteLine($"{J.getReference()} ");
            John.WriteScripture();
            if (John.AllHidden())
            {
                quit = "quit";
            }
            else
            {
            Console.WriteLine("\nPress Enter to Continue, type \"quit\" to quit");
            quit = Console.ReadLine();
            }
        }
        Console.WriteLine("Thanks for using my scripture memeorizer. ");
    }
}

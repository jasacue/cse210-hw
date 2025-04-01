using System.IO.Compression;

public class Scripture
{
    private string _text;
    private List<Word> _words = new List<Word>();
    
    private bool _isAllHidden;

    public Scripture(string text)
    {
        _text = text;
        _isAllHidden = false;


        
    }

    public void WriteScripture()
    {
        int w = 0;
        int i = 0;
        while (w != _words.Count())
        {
                Console.Write($"{_words[w].GetWord()} ");
                w +=1;
                
        }
        if (i == _words.Count())
        {
            Console.Clear();
            Console.WriteLine("Scripture Fully Hidden!");
            _isAllHidden = true;
            
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
    public void CheckAllHidden()
    {
        int e = 0;
        foreach(var i in _words)
        {
            if (i.CheckHidden())
            {
                e += 1;
            }
            else
            {
                e +=0;
            }
        }
        if (e== _words.Count())
        {
            _isAllHidden = true;
        }
    }
    public void HideNew()
    {
        int c;
        int i = 0;
        int z = 0;
        Random r = new Random();
        while(z != 3)
        {
            foreach (var w in _words)
            {
                c = r.Next(0, _words.Count());
                if (_words[c].CheckHidden())
                {
                    i+= 1;
                    if (i == _words.Count())
                    {
                        _isAllHidden = true;
                        break;
                    }
                    continue;

                }
                else
                {
                    _words[c].HideWord();
                    break;
                }
            }
            
            z += 1;
        }
    }
    public bool AllHidden()
    {
        return _isAllHidden;
    }
}
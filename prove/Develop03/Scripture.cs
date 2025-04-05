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
                continue; //ee
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
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
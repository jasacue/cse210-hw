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

    public string GetWord()
    {
        if (_isHidden == true)
        {
            return _wordHidden;
        }
        else
        {
            return _word;
        }
    }
    
    public bool CheckHidden()
    {
        return _isHidden;
    }


}
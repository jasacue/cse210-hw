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
        Condense();
    }
    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        Condense();
    }
    public void Condense()
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


    public string GetReference()
    {
        return $"{_full}";
    }
}

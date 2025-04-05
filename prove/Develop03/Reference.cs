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
        { //www
            refer = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        
        _full= refer;
    }


    public string getReference()
    {
        return $"{_full}";
    }
}

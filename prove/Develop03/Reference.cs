

public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endverse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
// Keeps track of the book, chapter and verses
public class Reference
{
    private string _book = "";
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    public Reference(string book, int chap, int fVerse, int sVerse)
    {
        _book = book;
        _chapter = chap;
        _verse = fVerse;
        _endVerse = sVerse;
    }

    public string GetDisplayReference()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}: ";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}: ";
        }
    }

}
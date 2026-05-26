// Responsibility: 
// Behavior: 
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    // Constructor(s)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        return "";
    }
}

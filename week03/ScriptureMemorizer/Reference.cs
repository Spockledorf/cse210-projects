// Responsibility: Represents a scripture reference (book, chapter, verse(s)).
// Behavior: Supports single verses and verse ranges, displays formatted reference text.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _verseEnd;

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
        if (_verseEnd.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
        return $"{_book} {_chapter}:{_verse}";
    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {
        string _chapterText = _chapter.ToString();
        string _verseText = _verse.ToString();
        string _endVerseText = _endVerse.ToString();

        if (_endVerseText == "0")
        {
            return $"{_book} {_chapterText}:{_verseText}";
        }

        else
        {
            return $"{_book} {_chapterText}:{_verseText}-{_endVerseText}";
        }

    }
}

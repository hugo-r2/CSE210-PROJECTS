public class Scripture
{

    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(w => new Word(w))
                     .ToList();

    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count(w => !w.IsHidden()));

        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = rand.Next(_words.Count);
            } while (_words[index].IsHidden());

            _words[index].Hide();
        }
    }


    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText();
        String wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{scriptureText} {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
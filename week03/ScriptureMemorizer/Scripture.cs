// Responsibility: 
// Behavior: 
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];

    // Constructor(s)
    public Scripture(Reference reference, string text)
    {
        // set reference
        _reference = reference;
        

        // Get word list
        // string[] parts = text.Split(" ");
        foreach (string word in text.Split(" "))
        {
            Word w = new Word(word);
            _words.Add(w);
        }

    }

    public void HideRandomWords() { }
    public string GetDisplayText()
    {
        string textReference = _reference.GetDisplayText();
        string wordsText = "";
        foreach (Word word in _words)
        {
            wordsText = $"{wordsText} {word.GetDisplayText()}";
            // if (word.IsHidden() == false)
            // {
            //     wordsText = wordsText + word;
            // }
            // else
            // {
            //     word.
            // }
        }
        return textReference + wordsText;
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
}

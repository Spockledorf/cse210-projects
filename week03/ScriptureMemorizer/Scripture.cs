// Responsibility: 
// Behavior: 
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor(s)
    public Scripture(Reference reference, string text)
    {
        // set reference
        _reference = reference;
        

        // Get word list
        // string[] parts = text.Split(" ");
        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            Word w = new Word(word);
            _words.Add(w);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = Random.Shared.Next(0, _words.Count);
            
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string displaytext;
        string textReference = _reference.GetDisplayText();
        StringBuilder verseText = new StringBuilder();

        foreach (Word word in _words)
        {
            verseText.Append($"{word.GetDisplayText()} ");
        }
        
        displaytext = textReference + " " + verseText.ToString();
        return displaytext;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

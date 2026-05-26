// Responsibility: 
// Behavior: 
using System.Text;

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

    public void HideRandomWords(int numberToHide)
    {
        // randomly select words from 
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

// Responsibility: 
// Behavior: 
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _difficultySetting = 3; // 1-10, adjusts how many words are hidden each pass. Default: 3
    private bool _punctuationHidden = false; // true or false, adjusts the hide/show word logic to include or exclude special characters. Default: false


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
            if (_punctuationHidden == true)
            {
                verseText.Append($"{word.GetDisplayTextAll()} ");
            }
            else
            {
                verseText.Append($"{word.GetDisplayText()} ");
            }
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
    public bool IsPunctuationHidden()
    {
        return _punctuationHidden;
    }
    private void HidePunctuation()
    {
        _punctuationHidden = true;
    }
    private void ShowPunctuation()
    {
        _punctuationHidden = false;
    }

    public int GetDifficulty()
    {
        return _difficultySetting;
    }
    private void SetDifficulty(int difficultySetting)
    {
        _difficultySetting = difficultySetting;
    }
    private void ResetDifficulty()
    {
        _difficultySetting = 3;
    }
    public void AdjustSettings(int difficultySetting, bool hidePunctuation)
    {
        _difficultySetting = difficultySetting;
        _punctuationHidden = hidePunctuation;
    }
}

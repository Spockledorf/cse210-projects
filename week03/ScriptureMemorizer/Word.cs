// Responsibility: 
// Behavior: 
public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor(s)
    public Word(string text)
    {
        _text = text.Trim();
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            // Replace all letter characters with '_'
            char[] chars = _text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    chars[i] = '_';
                }
            }

            return new string(chars);
        }
    }
    public string GetDisplayTextAll()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            // Replace all letter characters with '_'
            char[] chars = _text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    chars[i] = '_';
                }
            }

            return new string(chars);
        }
    }
}

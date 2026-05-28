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
            // Replace all characters with '_'
            // string hiddenText = new string('_', _text.Length);
            // return hiddenText;
            // TODO Consider replacing ONLY alphabet chars, preserving special characters at the end.
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

// Responsibility: Stores a number based on a numerator / denomenator.
// Behavior: 
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor(s)
    public Fraction()
    {
        SetTop(1);
        SetBottom(1);
    }
    public Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        SetBottom(1);
    }
    public Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    // Getters/Setters
    private int GetTop()
    {
        return _top;
    }
    private void SetTop(int top)
    {
        _top = top;
    }
    private int GetBottom()
    {
        return _bottom;
    }
    private void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Display Functions
    public string GetFractionString()
    {
        string fractionString = $"{GetTop()}/{GetBottom()}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double top = GetTop();
        double bottom = GetBottom();
        double decimalValue = top / bottom;
        return decimalValue;
    }
}

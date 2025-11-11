using System.Runtime.Versioning;

public class Fraction
{
    private int _nominator;
    private int _denominator;
    public Fraction()
    {
        _nominator = 1;
        _denominator = 1;
    }
    public Fraction(int toppNumber)
    {
        _nominator = toppNumber;
        _denominator = 1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _nominator = topNumber;
        _denominator = bottomNumber;
    }

    public void GetTop()
    {
        Console.WriteLine(_nominator);
    }
    public int SetTop(int topNumber)
    {
        _nominator = topNumber;
        return _nominator;
    }
    public void GetBottom()
    {
        Console.WriteLine(_denominator);

    }
    public int SetBottom(int bottomNumber)
    {
        _denominator = bottomNumber;
        return _denominator;
    }
    public string GetFractionString()
    {
        return $"{_nominator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)_nominator / (double)_denominator;
        return decimalValue;
    }

}

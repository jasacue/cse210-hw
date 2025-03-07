using System.Dynamic;
using System.Runtime.CompilerServices;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _bottomNumber = 1;
        _topNumber = top;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber =top;
        _bottomNumber = bottom;
    }
    public int GetTopNubmer()
    {
        return _topNumber;
    }

    public void SetTopNumber(int top)
    {
        _topNumber = top;
    }
    public int GetBottomNubmer()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractonString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }
    public double GetDecimalValue()
    {
        double top;
        double bottom;
        top = Convert.ToDouble(_topNumber);
        bottom = Convert.ToDouble(_bottomNumber);
        return (top/bottom);
    }
}
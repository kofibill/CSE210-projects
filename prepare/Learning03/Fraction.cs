using System;

public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int top)
    {
        _topNum = top;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum= top;
        _bottomNum = bottom;
    }

    public int GetTopNum()
    {
        return _topNum;
    }
    public void SetTopNum(int topn)
    {
        _topNum = topn;
    }

    public int GetBottNum()
    {
        return _bottomNum;
    }
    public void SetBottNum(int botn)
    {
        _bottomNum = botn;
    }

    
}
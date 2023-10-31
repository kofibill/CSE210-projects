using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word =word;
        _hidden = false;
    }

    public string Hide()
    {
        string tmp = "";
        for (int _ = 0; _ < _word.Length; _++)
        {
            tmp += "_";
        }
        return tmp;
    }

    public void Procedure()
    {
        _hidden = true;
    }
           

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRendered()
    {
        return _word;
    }

    public void Display()
    {
        Console.WriteLine(_word);
    }
    

}
using System;

public class Scripture
{
    private Reference _reference;
    private  List<Word> _words = new List<Word>();

    public Scripture( Reference reference, string words)
    {
        _reference = reference;
        string[] array = words.Split(' ');
        foreach (string x in array)
         {
            Word word = new Word(x);
            _words.Add(word);

         }
    }

    public void HideWords()
    {
        
    }

    public void GetRenderedText()
    {

    }

    public void IsCompletelyHidden()
    {

    }


}

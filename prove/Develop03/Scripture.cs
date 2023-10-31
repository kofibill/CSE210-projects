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
            Console.WriteLine(word);

         }
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int tmp_candidate = rnd.Next(_words.Count);
        _words[tmp_candidate].Procedure();
        if (_words[tmp_candidate].IsHidden())
        {
            
        }
        else
        {
            _words[tmp_candidate].Procedure();
        }
    }

    public void PrintText()
    {
        Console.Write(_reference.GetText() +" ");
        foreach(Word x in _words)
        {

            if (x.IsHidden())
            {
                Console.Write(x.Hide());
            }
            else
                {
                    Console.Write(x.GetRendered());
                }
                Console.Write(" ");
            
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach( Word x in _words)
        {
            if (!x.IsHidden())
            {
                return false;
            }
            
        }
        return true;
    }


}

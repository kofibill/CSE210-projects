using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    //private int _verseEnd;

   
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{verseStart}- {verseEnd}";
        //_verseEnd = verseEnd;
    }

     public Reference(string book, string chapter, string verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verse = verseStart;
    }

    public string GetText()
     {
         return $"{_book} {_chapter} : {_verse}";
     }
    
    
}
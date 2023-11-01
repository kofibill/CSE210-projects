using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {        
        Reference myref = new Reference("John", 1 , 1 , 3 );
        Scripture myscrip = new Scripture(myref, @"""In the beginning was the Word, and the Word was with God, and the word was God. The same was in the beginning with God.
        All things were made by him; and without him was not any thing made that was made.""");
        
        Reference myref2 = new Reference("Matthew", 3, 1, 2);
        Scripture myscrip2 = new Scripture(myref2, @"""In those days came John the Baptist, preachng in the wilderness
        of Judea, And saying, repent ye:for the kingdom of heaven is at hand. """);

        Reference myref3 = new Reference("Matthew", 9, 35, 36);
        Scripture myscrip3 = new Scripture(myref3, @"""And Jesus went about all the cities and villages, teaching in 
        their synagogues, and preaching the gospel of the kingdom and healing every sickness and every disease among
        the people. But when he saw the multitudes, he was moved with compasssion on them, because they fainted and were
        scarttered abroad, as sheep having no shepherd. """);

        List<Scripture> _scriptures = new List<Scripture>();
        _scriptures.Add(myscrip);
        _scriptures.Add(myscrip2);
        _scriptures.Add(myscrip3);

        Random random = new Random();
        int index =random.Next(_scriptures.Count);
        Scripture _scripture = _scriptures[index];

         _scripture.PrintText();
          Console.WriteLine("");
          Console.WriteLine("");
          Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string myMessage= "";
        while (myMessage != "quit" & _scripture.IsCompletelyHidden() == false)
        {
            myMessage = Console.ReadLine().Trim().ToLower();
            _scripture.HideWords();
            Console.Clear();
            _scripture.PrintText();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        }
    } 

    /* I exceeded the requirements by making my program work with a library of scriptures. The program 
    chooses at random any of the three scriptures and presents it to the user.
    */
}
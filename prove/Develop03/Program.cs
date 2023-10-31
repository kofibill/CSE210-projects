using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myref = new Reference("John","1","1","3");
        Scripture myscrip = new Scripture(myref, @"""In the beginning was the Word, and the Word was with God,and the word was God. The same was in the beginning with God.
        All things were made by him; and without him was not any thing made that was made.""");

        while (true)
        {
            Console.Clear();
            myscrip.PrintText();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string myMessage = Console.ReadLine().Trim().ToLower();
            if (myMessage == "quit") break;
            if (myscrip.IsCompletelyHidden()) break;
            myscrip.HideWords();
        }
    }     
}
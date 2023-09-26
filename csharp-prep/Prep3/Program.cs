using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator =new Random();
        int magicnum =randomgenerator.Next(1, 100);

        int guessnum = 0;

        while(guessnum != magicnum)
        {
            Console.Write("What is the guess number? ");
            guessnum=int.Parse(Console.ReadLine());

            if (guessnum > magicnum)
            {
                Console.WriteLine("Guess lower");
            }
            else if(guessnum < magicnum)
            {
                Console.WriteLine("Guess higher");
            }
            else
            {
                Console.WriteLine("You guessed the right number");
            }
        }   
           
    }
}
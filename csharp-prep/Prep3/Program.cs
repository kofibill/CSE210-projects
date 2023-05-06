using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicnum=int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guessnum=int.Parse(Console.ReadLine());

        if(guessnum < magicnum)
        {
            Console.Write("Incorect, please guess higher!!");
        }
        else if(guessnum > magicnum)
        {
            Console.Write("Incorrect guess, please guess lower!!");
        }
        else
        {
            Console.Write("Correct, you guessed right!!");
        }
    }
}
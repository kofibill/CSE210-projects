using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name= PromptUserName();

        int num= PromptUserNumber();

        int number=  SquareNumber(6);

        DisplayResults(name, num);

        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!!");
    }
    
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string username=Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int fav=int.Parse(Console.ReadLine());
        return fav;
    }

    static int SquareNumber(int fav)
    {
        int num= fav * fav;
        return num;
    }

    static void DisplayResults(string username, int fav)
    {
       Console.WriteLine($"{username}, the number of your square is {fav}");
    }
}
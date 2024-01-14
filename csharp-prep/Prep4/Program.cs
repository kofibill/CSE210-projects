using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>();

        int userNumber=-1;

        while(userNumber !=0)
        {
            Console.Write("Please enter a series of numbers. Type 0 when finished: ");
            string response=Console.ReadLine();
            userNumber=int.Parse(response);

            if (userNumber!=0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The Sum is: {sum}");
    }
}    
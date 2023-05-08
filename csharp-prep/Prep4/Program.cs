using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>();

        int holder=0;

        while(holder ==0)
        {
            Console.Write("Please enter a series of numbers. Type 0 when finished: ");
            string response=Console.ReadLine();
            holder=int.Parse(response);

            if (holder!=0)
            {
                numbers.Add(holder);
            }
        }
    }
}    
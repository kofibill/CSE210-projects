using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade: ");
        string grade=Console.ReadLine();
        int gradenumber=int.Parse(grade);

        if (gradenumber >=90)
        {
            Console.Write("You had an A, well done keep it up");
        }
        else if (gradenumber >=80)
        {
            Console.Write("You had a B, well done keep it up");
        }
        else if (gradenumber >=70)
        {
            Console.Write("You had a C, well done, but there is more room for inprovment");
        }
        else if (gradenumber >=60)
        {
            Console.Write("You had a D, please try to improve upon it, you can do it!!");
        }
        else if (gradenumber <=60)
        {
            Console.Write("This is an F, please study hard next time. You can do this!!");
        }
    }
}
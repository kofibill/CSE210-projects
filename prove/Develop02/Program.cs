using System;
using System.IO.Enumeration;

class Program
{

    static void Main(string[] args)
    {

        Journal myjournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program ");
        Person person = new Person();
        person.Display();
        int options = 0;
        while (options != 5)

           {
             Console.WriteLine("");
             Console.WriteLine("1. Write");
             Console.WriteLine("2. Display");
             Console.WriteLine("3. Load");
             Console.WriteLine("4. Save");
             Console.WriteLine("5. Quit");
             Console.Write("Please enter an option: ");
             options = int.Parse(Console.ReadLine());

             if (options == 1)
             {
                Entry entry= new Entry();
                myjournal.AddEntry(entry);
             }
                
             else if (options == 2)
             {
             // journal.DisplayAllEntries()
                Entry entry=new Entry();
                 myjournal.DisplayJornal();
             }
             else if (options == 3)
             {
                Console.WriteLine("Please enter a file name");
                string fileName = Console.ReadLine();
                myjournal.LoadToFile(fileName);
             }
             else if (options == 4)
             {
                Console.WriteLine("Please enter a file name");
                string fileName = Console.ReadLine();
                myjournal.SaveToFile(fileName);
             }

             else if (options ==5)
             {

             }
             
            }
    }
}
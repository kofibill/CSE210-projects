using System;

class Program
{
    static void Main(string[] args)
    {
        string response ="";
        while (response != "5")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1.Breathing Activity");
            Console.WriteLine("2.Reflecting Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("4.Push Up Activity");
            Console.WriteLine("5.Quit");
            Console.WriteLine();
            Console.Write("Which Activity would you like to do? ");
            response= Console.ReadLine();

            if (response == "1")
            {
                BreathingActivity breathact = new BreathingActivity("The Breating Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathact.RunActivity();
            }
            else if (response == "2")
            {
                ReflectionActivity reflec = new ReflectionActivity("The Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflec.RunActivity();
            }

            else if (response == "3")
            {
                ListingActivity listact = new ListingActivity("The Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listact.RunActivity();
            }
            else if (response == "4")
            {
                PushUpActivity push = new PushUpActivity("The Push Up Activity","This push up activity is to help you exercise to improve your chest and have stronger arms.");
                push.RunActivity();
            }
            else if (response =="5")
            {

            }
        }
            /*
            I showed creativity by adding another kind of activity. This activity is called the Push up activity which
            is an excersie that helps improve the chest of the person and enables the person get stronger arms.
            */
       
    }
}
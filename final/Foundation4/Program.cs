using System;

class Program
{
    static void Main(string[] args)
    {
        // A list of activity
        List<Activity> activity = new List<Activity>();

        // Instantiate instances of Running, Cycling and Swimming class
        Running runningActivity = new Running(10, 40, "16 Jan 2024");
        Cycling cyclingActivity = new Cycling(20, 38, "20 Jan 2024");
        Swimming swimmingActivity = new Swimming(40, 42, "30 Jan 2024");

        // Add the instances to the Activity list
        activity.Add(runningActivity);
        activity.Add(cyclingActivity);
        activity.Add(swimmingActivity);

        // Loop through the activity list and output the results
        foreach (Activity sport in activity)
        {
            Console.WriteLine(sport.GetSummary());
            Console.WriteLine();
        }   
    
    }
}
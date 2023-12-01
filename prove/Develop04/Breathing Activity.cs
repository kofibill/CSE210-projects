using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayBreathIn()
    {
        Console.Write("Breathe In...");
        PauseWithCountDown();
    }
    public void DisplayBreathOut()
    {
        Console.Write("Breathe Out...");
        PauseWithCountDown();
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;
        while (currentTime < futureTime)
        {
            DisplayBreathIn();
            DisplayBreathOut();
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }

}
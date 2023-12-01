using System;
public class PushUpActivity : Activity
{
    public PushUpActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayPushUp()
    {
        Console.Write("Push Up...");
        PauseWithCountDown();
    }
    public void DisplayPushDown()
    {
        Console.Write("Push Down...");
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
            DisplayPushDown();
            DisplayPushUp();
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
        Console.WriteLine("You will remain strong if you do this activity everyday. Keep it up!!");
    }

}
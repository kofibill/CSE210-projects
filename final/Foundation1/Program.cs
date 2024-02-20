using System;

class Program
{
    static void Main(string[] args)
    

    {

        List<Videos> videosList = new List<Videos>();

        // Video 1
        Console.WriteLine("YouTube Videos....");
        Console.WriteLine("");   
        Videos video1 = new Videos("Yaa Asantewa:Queen warrior of Ghana", "Lindsay Holiday", 1320);

        Comments video1Comment1 = new Comments("William", "Intersting History!! She is from my country. Im so proud to be an Ashanti woman. Thanks for doing this, much appreciated.");
        Comments video1Comment2 = new Comments("Clifford", "Im glad to learn more about this history. Very inspiring.");
        Comments video1Comment3 = new Comments("Tanner", "Great history. Greeting to the people of Ghana.");

        video1.Comments(video1Comment1);
        video1.Comments(video1Comment2);
        video1.Comments(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Videos video2 = new Videos("The Ashanti War 1873 & Wolseley's Ashanti Ring", "The history Chap", 1200);

        Comments video2Comment1 = new Comments("Seth Addo", "Such an amazing story. Shows the ashantis defended their lands.");
        Comments video2Comment2 = new Comments("Goerge Ahmed", "Great vidoe here. Very educative");
        Comments video2Comment3 = new Comments("Rebecca", "The ashantis have alwasy been a great kingdom from day one");

        video2.Comments(video2Comment1);
        video2.Comments(video2Comment2);
        video2.Comments(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Videos video3 = new Videos("The Disastrous Anglo-Zulu War", "History Dose", 780);

        Comments video3Comment1 = new Comments("Parker Davis", "Great laerning african history");
        Comments video3Comment2 = new Comments("Jill Davis", "Nice and vivid presentation. Well educative.");
        Comments video3Comment3 = new Comments("Fernando Garcia", "Nice vidoe. Hope to recieve more of this content.");

        video3.Comments(video3Comment1);
        video3.Comments(video3Comment2);
        video3.Comments(video3Comment3);

        videosList.Add(video3);

        foreach (Videos video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    
    }
}
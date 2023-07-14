using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create Running activity
        Running running = new Running();
        running.Date = DateTime.Now;
        running.Length = 60;
        running.Distance = 5.0;
        activities.Add(running);

        // Create Cycling activity
        Cycling cycling = new Cycling();
        cycling.Date = DateTime.Now;
        cycling.Length = 45;
        cycling.Speed = 18.0;
        activities.Add(cycling);

        // Create Swimming activity
        Swimming swimming = new Swimming();
        swimming.Date = DateTime.Now;
        swimming.Length = 30;
        swimming.Laps = 20;
        activities.Add(swimming);

        // Display activity summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

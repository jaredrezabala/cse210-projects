class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create Running Activity
        Running runningActivity = new Running();
        runningActivity.Length = 30; // Set length in minutes
        runningActivity.Distance = 5.5; // Set distance in miles
        activities.Add(runningActivity);

        // Create Swimming Activity
        Swimming swimmingActivity = new Swimming();
        swimmingActivity.Length = 45; // Set length in minutes
        swimmingActivity.Distance = 1.2; // Set distance in miles
        swimmingActivity.Laps = 20; // Set number of laps
        activities.Add(swimmingActivity);

        // Create Cycling Activity
        Cycling cyclingActivity = new Cycling();
        cyclingActivity.Length = 60; // Set length in minutes
        cyclingActivity.Distance = 10.0; // Set distance in miles
        cyclingActivity.Speed = 18.5; // Set speed in miles per hour
        activities.Add(cyclingActivity);

        // Display activity details
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
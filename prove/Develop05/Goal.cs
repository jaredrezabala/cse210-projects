class Goal
{
    public void DisplayScore()
    {
        Console.WriteLine("You have x points");
        Console.WriteLine();

    }
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1) Create New Goal");
        Console.WriteLine("2) List Goals");
        Console.WriteLine("3) Save Goals");
        Console.WriteLine("4) Load Goals");
        Console.WriteLine("5) Record Event");
        Console.WriteLine("6) Quit");
        Console.WriteLine("");
        Console.WriteLine("Select a choice for the menu:");
        string choice = Console.ReadLine();

        if(choice == "1")
        {
            Console.WriteLine("The types of Goals are:"); 
            Console.WriteLine("1. Simple Goal"); 
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create?");
            string input = Console.ReadLine();
            if(input == "1")
            {
                EnterGoalDetails();
            }
            else if(input == "2")
            {
                EnterGoalDetails();
            }
            else if (input == "3")
            {
                EnterGoalDetails();
            }
         
        }

    }
    public void EnterGoalDetails()
    {
        string goalName;
        string description;
        string numberOfPointsPerGoal;

        Console.WriteLine("What is the name of your goal?");
        goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it");
        description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        numberOfPointsPerGoal = Console.ReadLine();
    }
    // public void RecordEvent()
    // {
    //     string Event = Console.ReadLine("Please enter your event:");

    // }
    // public bool isComplete(){

    //     return true;
    // }
}
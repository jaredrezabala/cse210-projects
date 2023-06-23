using System;
class Goal
{

    public void DisplayScore()
    {
        Console.WriteLine("You have x points");
        Console.WriteLine();

    }
    public void DisplayMenu()
    {
        bool runProgram = false;
        while(runProgram != true)
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
            else if(choice == "2")
            {
                List<string[]> goalList = EnterGoalDetails();
                foreach (string[] goalInputs in goalList)
                {
                    foreach(string item in goalInputs)
                    Console.WriteLine(item);
                }
            }
            
            
            else if(choice == "6")
            {
                Console.WriteLine("Goobye");
                runProgram = true;

            }
        }
    }
    public List<string[]> EnterGoalDetails()
    {
        List<string[]> goalList = new List<string[]>();
        // Goal goal = new Goal();
        // string goalName;
        // string description;
        // string numberOfPointsPerGoal;
        string[] goalInputs = new string[3];

        Console.WriteLine("What is the name of your goal?");
        // goalName = Console.ReadLine();
        goalInputs[0] = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        // description = Console.ReadLine();
        goalInputs[1] = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        // numberOfPointsPerGoal = Console.ReadLine();
        goalInputs[2] = Console.ReadLine();

        goalList.Add(goalInputs);

        return goalList;
    }
    // public void RecordEvent()
    // {
    //     string Event = Console.ReadLine("Please enter your event:");

    // }
    // public bool isComplete(){

    //     return true;
    // }
}
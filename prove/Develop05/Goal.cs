using System;
using System.IO;
class Goal
{
    List<string[]> goalList = new List<string[]>();

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
                foreach (string[] goalInputs in goalList)
                {
                    foreach (string item in goalInputs)
                        {
                            Console.Write("[]"+item[1]);
                        }
                }
            }
            else if(choice == "3")
            {
                GoalManager();

            }
            else if(choice == "4"){
                
            }
            else if(choice == "5"){
                
            }
            else if(choice == "6")
            {
                Console.WriteLine("Goobye");
                runProgram = true;

            }
        }
    }
    public void EnterGoalDetails()
    {
        string[] goalInputs = new string[3];
        Console.WriteLine("What is the name of your goal?");
        goalInputs[0] = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        goalInputs[1] = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        goalInputs[2] = Console.ReadLine();

        goalList.Add(goalInputs);

     
    }
    public void GoalManager()
    {
        string fileName = "";
        Console.WriteLine("What is the filename for the goal file?");
        fileName = Console.ReadLine();
        using(StreamWriter writer = new StreamWriter(fileName))
        {
            foreach(string[] goalInputs in goalList)
            {
                writer.Write(goalInputs[0]+","+goalInputs[1]+","+ goalInputs[2]);
            }

        }

    }
 
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace mindfulness
// {
    class ListingActivity:Activity
    {
        public void DisplayMessage()
        {
           
            Console.WriteLine("Welcome to the Listing Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
            Console.WriteLine();
            //Display question of how many seconds the user wants the setion to be
            //Display Get ready... 
            //run spinner
            Console.WriteLine("Enter the duration in seconds for running the code:");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                Spiner();
                ListItems(duration);
                DiplayEndingMessage();
                Console.WriteLine("You have completed another " + duration+ " seconds of the Breathing Activity.");
            }
        }
        public void ListItems(int duration) 
        {
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine();
            List<string> prompts = new List<string>();
            prompts.Add("Who are people that you appreciate?");
            prompts.Add("What are personal strengths of yours?");
            prompts.Add("Who are people that you have helped this week?");
            prompts.Add("When have you felt the Holy Ghost this month?");
            prompts.Add("Who are some of your personal heroes?");
            //make so that it is choose only one 
            //after the ramdonm prompt is selected run the countdown
            Random random = new Random();
            int randomNumber = random.Next(0, prompts.Count);
            Console.WriteLine(prompts[randomNumber]);
            Console.WriteLine();
            Console.WriteLine("You may begin in:"); 
            //number countdown
            Timer();
            Console.WriteLine("Start typing and press enter after each response");
            //make a list of responses
            List<string> responses = new List<string>();
            DateTime startTime = DateTime.Now;
            while (DateTime.Now - startTime <= TimeSpan.FromSeconds(duration))
            {
                string response = Console.ReadLine();
                responses.Add(response);
            
            }

            //let the user list as many experiences as posible in a different line until the time is over
            //display ending msg with the set msg "You have completed another x seconds of the Listing Activity
            //run spinner
            //go back to menu
        }
    }
// }

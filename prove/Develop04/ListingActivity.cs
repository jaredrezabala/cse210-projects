using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ListingActivity:Activity
    {
        public void DisplayMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Listing Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
            Console.WriteLine();
            Console.WriteLine("How long, in seconds, would you like for your session?");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Get ready...");
                Spiner();
                ListItems(duration);
                Console.WriteLine();
                DiplayEndingMessage();
                Spiner();
                Console.WriteLine();
                Console.WriteLine("You have completed another " + duration+ " seconds of the Listing Activity.");
                Spiner();
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
            Random random = new Random();
            int randomNumber = random.Next(0, prompts.Count);
            Console.WriteLine(prompts[randomNumber]);
            Console.WriteLine();
            Console.WriteLine("You may begin in:"); 
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
                Console.WriteLine();
                Console.WriteLine("You listed "+responses.Count+" items");
                Console.WriteLine();

           
        }
    }


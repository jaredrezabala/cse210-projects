using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ReflectingActivity:Activity
    {
        
        public void DisplayMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Reflecting Activity");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
            Console.WriteLine("");
        
            Console.WriteLine("How long, in seconds, would you like for your session?");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Get ready...");
                Spiner();  
                DisplayRandomPrompt();
                DisplayQuestions(duration);
                Console.WriteLine();
                DiplayEndingMessage();
                Spiner();
                Console.WriteLine();
                Console.WriteLine("You have completed another " + duration+ " seconds of the Reflecting Activity.");
                Spiner();
            }
            

        }
        public void DisplayRandomPrompt()
        {
            Console.WriteLine("Consider the following prompt:"); 
            Console.WriteLine();
            List<string> prompts = new List<string>();
            prompts.Add("Think of a time when you stood up for someone else.");
            prompts.Add("Think of a time when you did something really difficult.");
            prompts.Add("Think of a time when you helped someone in need.");
            prompts.Add("Think of a time when you did something truly selfless.");
            //use random method to choose one and display it 
            Random random = new Random();
            int index = random.Next(0, prompts.Count);
            Console.WriteLine(prompts[index]);
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue");
            Console.ReadLine();
            


        }
        public void DisplayQuestions(int duration)
        {
            Console.WriteLine("Now ponder on each of the following questions as they are related to this experience");
            Console.WriteLine();
            Console.WriteLine("You may begin in:"); 
            Timer();
            Console.WriteLine();
            List<string> questions = new List<string>();
            questions.Add("Why was this experience meaningful to you?");
            questions.Add("Have you ever done anything like this before?");
            questions.Add("How did you get started?");
            questions.Add("How did you feel when it was complete?");
            questions.Add("What made this time different than other times when you were not as successful?");
            questions.Add("What is your favorite thing about this experience?");
            questions.Add("What could you learn from this experience that applies to other situations?");
            questions.Add("What did you learn about yourself through this experience?");
            questions.Add("How can you keep this experience in mind in the future?");
            //after each question I need to run the spinner for several seconds
            DateTime startTime = DateTime.Now;
            while (DateTime.Now - startTime <= TimeSpan.FromSeconds(duration))
            {
                foreach (string item in questions)
                {
                    if(DateTime.Now - startTime > TimeSpan.FromSeconds(duration))
                        break;

                    Console.WriteLine(item);
                    Spiner();

                }
                       
            }
        }

        
    }


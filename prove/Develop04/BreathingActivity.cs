using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace mindfulness
// {
    class BreathingActivity: Activity
    {
        public void DisplayMessage()

        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the breathing activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

            //add a loop to get this 2 messages going until the number of seconds that the user entered are over
            Console.WriteLine("Enter the duration in seconds for running the code:");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                // BreathingActivity inheritance = new BreathingActivity();
                Console.WriteLine("Get ready...");
                Spiner();
                DateTime startTime = DateTime.Now;
                while (DateTime.Now - startTime <= TimeSpan.FromSeconds(duration))
                {
                    Console.WriteLine("Breathe in..."); 
                    Timer();//add timer
                    Console.WriteLine("Now Breathe out..."); 
                    Timer();//add timer

                }
                
                // Thread.Sleep(duration * 1000);
                Console.WriteLine();
                DiplayEndingMessage();
                Spiner();
                Console.WriteLine();
                Console.WriteLine("You have completed another " + duration+ " seconds of the Breathing Activity.");
                Console.WriteLine();
                Spiner();
                
            }
            // Console.ReadLine();
            //display ending message
            //run the spinner
            //display message saying "You have completed another 30 seconds of the Breathing Activity." the seconds will depend of the number of seconds the user entered in the first place"
            //run spinner
            //return to Menu
        }


    }
// }

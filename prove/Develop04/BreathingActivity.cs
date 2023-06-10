using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BreathingActivity: Activity
    {
        public void DisplayMessage()

        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the breathing activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

            
            Console.WriteLine("Enter the duration in seconds for running the code:");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
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
                
                
                Console.WriteLine();
                DiplayEndingMessage();
                Spiner();
                Console.WriteLine();
                Console.WriteLine("You have completed another " + duration+ " seconds of the Breathing Activity.");
                Console.WriteLine();
                Spiner();
                
            }
            
        }


    }


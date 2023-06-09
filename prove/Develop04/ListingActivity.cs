using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindfulness
{
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
        }
        public void ListItems() 
        {
            List<string> prompts = new List<string>();
            prompts.Add("Who are people that you appreciate?");
            prompts.Add("What are personal strengths of yours?");
            prompts.Add("Who are people that you have helped this week?");
            prompts.Add("When have you felt the Holy Ghost this month?");
            prompts.Add("Who are some of your personal heroes?");
            //make so that it is choose only one 
            //after the ramdonm prompt is selected run the countdown
            Console.WriteLine("You may begin in:"); //number countdown
            //let the user list as many experiences as posible in a different line until the time is over
            //display ending msg with the set msg "You have completed another x seconds of the Listing Activity
            //run spinner
            //go back to menu
        }
    }
}

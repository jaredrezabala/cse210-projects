using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace mindfulness
// {
    class ReflectingActivity:Activity
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Reflecting Activity");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
            Console.WriteLine("");
            //ask question how long the user want the activity to go for
            Console.WriteLine("Get ready");
            //run spinner

        }
        public void DisplayRandomPrompt()
        {
            List<string> prompts = new List<string>();
            prompts.Add("Think of a time when you stood up for someone else.");
            prompts.Add("Think of a time when you did something really difficult.");
            prompts.Add("Think of a time when you helped someone in need.");
            prompts.Add("Think of a time when you did something truly selfless.");
            //use random method to choose one and display it 
            Console.WriteLine("When you have something in mind, press enter to continue");
            //add an input enter an when the user press it then show the next part


        }
        public void DisplayQuestions()
        {
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

        }

        //This activity should end with the ending msg and with this msg "You have completed another x seconds of the Reflecting Activity " 
        //Display Menu Again

    }
// }

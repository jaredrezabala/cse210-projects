using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace mindfulness
// {
    class Activity
    {
        public void Spiner()
        { 
                List<string> animationStrings = new List<string>();
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.WriteLine(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public void Timer()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public int DurationOfActivity(int a)
        {
            Console.WriteLine("How long, in seconds, would you like for your session?");
            return a;
        }
        public void DiplayEndingMessage()
        {
            Console.WriteLine("Thanks for participating in this activity, you did it a great job!");
        }
    }
// }

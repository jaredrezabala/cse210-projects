using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public void Timer()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void DiplayEndingMessage()
        {
            Console.WriteLine("Thanks for participating in this activity, you did it a great job!");
        }
    }


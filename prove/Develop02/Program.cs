using System;

class Program
{
    static void Main(string[] args)
    {
        string choices = "";
        do
        {
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choices = Console.ReadLine();
            string[] prompts = {"What are three things that you're grateful for today?",
                                "Describe a recent challenge you faced and how you overcame it.",
                                "Write about a moment that made you feel proud of yourself.",
                                "What's something that you've been procrastinating on, and what steps can you take to start working on it?",
                                "Write about a recent accomplishment that you're proud of."};
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            string randomPrompt = prompts[randomNumber];
            string fileName = "prompts.txt";
            string fileContent = "";

            if(choices == "1")
            {
                Console.WriteLine(randomPrompt);
                string promptAnswer = Console.ReadLine();

                DateTime currentDate = DateTime.Now;
                fileContent = $"Date:{currentDate.ToString()}\n - Prompt:{randomPrompt}\n Answer:{promptAnswer}"; 
                
                File.WriteAllText(fileName, fileContent);

                // Aquí llamamos a la clase PromptResponder para imprimir una frase de respuesta
                PromptResponder.Respond(promptAnswer);

            }
            else if(choices == "2")
            {
                string fileContentRead = File.ReadAllText(fileName);
                Console.WriteLine("\nFile content:");
                Console.WriteLine(fileContentRead);
            }
            else if(choices == "3")
            {
                File.AppendAllText("prompts.txt", fileContent);
            }
            else if(choices == "4")
            {
                string journal = File.ReadAllText("prompts.txt");
                Console.WriteLine("\nFile content:");
                Console.WriteLine(journal);
            }
        } while (choices != "5");
    }
}

public static class PromptResponder
{
    public static void Respond(string promptAnswer)
    {
        Console.WriteLine($"Thanks for your answer: {promptAnswer}");
    }
}

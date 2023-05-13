using System;
using System.IO;

class PromptJournal
{
    private string fileName;
    private string[] prompts = {"What are three things that you're grateful for today?",
                                "Describe a recent challenge you faced and how you overcame it.",
                                "Write about a moment that made you feel proud of yourself.",
                                "What's something that you've been procrastinating on, and what steps can you take to start working on it?",
                                "Write about a recent accomplishment that you're proud of."};

    public PromptJournal(string fileName)
    {
        this.fileName = fileName;
    }

    public void WritePrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 5);
        string randomPrompt = prompts[randomNumber];

        Console.WriteLine(randomPrompt);
        string promptAnswer = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        string fileContent = $"Date:{currentDate.ToString()}\n - Prompt:{randomPrompt}\n Answer:{promptAnswer}"; 

        File.WriteAllText(fileName, fileContent);
    }

    public void DisplayPrompt()
    {
        string fileContentRead = File.ReadAllText(fileName);
        Console.WriteLine("\nFile content:");
        Console.WriteLine(fileContentRead);
    }

    public void LoadPrompts()
    {
        string journal = File.ReadAllText(fileName);
        Console.WriteLine("\nFile content:");
        Console.WriteLine(journal);
    }

    public void SavePrompts(string content)
    {
        File.AppendAllText(fileName, content);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string choices = "";
        PromptJournal promptJournal = new PromptJournal("prompts.txt");

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

            if(choices == "1")
            {
                promptJournal.WritePrompt();
            }
            else if(choices == "2")
            {
                promptJournal.DisplayPrompt();
            }
            else if(choices == "3")
            {
                promptJournal.LoadPrompts();
            }
            else if(choices == "4")
            {
                Console.WriteLine("Enter content to save:");
                string content = Console.ReadLine();
                promptJournal.SavePrompts(content);
            }
        } while (choices != "5");
    }
}

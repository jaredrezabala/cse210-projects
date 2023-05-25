using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Answer { get; set; }
}

class Journal
{
    private string fileName;
    private List<Entry> entries;

    public Journal(string fileName)
    {
        this.fileName = fileName;
        this.entries = new List<Entry>();
    }

    public void WriteEntry()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 5);
        string[] prompts = {
            "What are three things that you're grateful for today?",
            "Describe a recent challenge you faced and how you overcame it.",
            "Write about a moment that made you feel proud of yourself.",
            "What's something that you've been procrastinating on, and what steps can you take to start working on it?",
            "Write about a recent accomplishment that you're proud of."
        };
        string randomPrompt = prompts[randomNumber];

        Console.WriteLine(randomPrompt);
        string promptAnswer = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        Entry entry = new Entry()
        {
            Date = currentDate,
            Prompt = randomPrompt,
            Answer = promptAnswer
        };
        entries.Add(entry);

        SaveEntries();
        PromptResponder.Respond(promptAnswer);
    }

    public void DisplayEntries()
    {
        LoadEntries();
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date.ToString()}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Answer: {entry.Answer}");
            Console.WriteLine();
        }
    }

    public void SaveEntries()
    {
        using (StreamWriter writer = File.AppendText(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date:{entry.Date.ToString()}");
                writer.WriteLine($"- Prompt:{entry.Prompt}");
                writer.WriteLine($"Answer:{entry.Answer}");
                writer.WriteLine();
            }
        }
    }

    public void LoadEntries()
    {
        entries.Clear();
        using (StreamReader reader = File.OpenText(fileName))
        {
            string line;
            Entry entry = null;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date:"))
                {
                    entry = new Entry();
                    entries.Add(entry);

                    string dateString = line.Substring("Date:".Length).Trim();
                    entry.Date = DateTime.Parse(dateString);
                }
                else if (line.StartsWith("- Prompt:"))
                {
                    entry.Prompt = line.Substring("- Prompt:".Length).Trim();
                }
                else if (line.StartsWith("Answer:"))
                {
                    entry.Answer = line.Substring("Answer:".Length).Trim();
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string choices = "";
        Journal journal = new Journal("journal.txt");

        do
        {
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Quit");
            Console.WriteLine("What would you like to do?");
            choices = Console.ReadLine();

            if (choices == "1")
            {
                journal.WriteEntry();
            }
            else if (choices == "2")
            {
                journal.DisplayEntries();
            }
        } while (choices != "3");
    }
}

public static class PromptResponder
{
    public static void Respond(string promptAnswer)
    {
        Console.WriteLine($"Thanks for your answer: {promptAnswer}");
    }
}


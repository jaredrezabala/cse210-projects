using System;
using System.Collections.Generic;

namespace ScriptureProgram
{
    class Word
    {
        public string Text { get; }
        public bool Hidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            Hidden = false;
        }

        public void Hide()
        {
            Hidden = true;
        }

        public override string ToString()
        {
            return Hidden ? "*****" : Text;
        }
    }

    class ScriptureReference
    {
        public string Book { get; }
        public int Chapter { get; }
        public int StartVerse { get; }
        public int? EndVerse { get; }

        public ScriptureReference(string book, int chapter, int startVerse, int? endVerse = null)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        public override string ToString()
        {
            if (EndVerse.HasValue)
            {
                return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
            }
            else
            {
                return $"{Book} {Chapter}:{StartVerse}";
            }
        }
    }

    class Scripture
    {
        private readonly List<Word> words;

        public ScriptureReference Reference { get; }
        public IReadOnlyList<Word> Words => words;

        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            words = new List<Word>();

            foreach (string word in text.Split(' '))
            {
                words.Add(new Word(word));
            }
        }

        public bool HideRandomWord()
        {
            List<Word> unhiddenWords = new List<Word>();
            foreach (Word word in words)
            {
                if (!word.Hidden)
                {
                    unhiddenWords.Add(word);
                }
            }

            if (unhiddenWords.Count == 0)
            {
                return false;
            }

            Random random = new Random();
            int randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
            return true;
        }

        public void Display()
        {
            Console.WriteLine($"{Reference}\n");
            foreach (Word word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n");
        }

        public bool AllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (!word.Hidden)
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        private static void ClearConsole()
        {
            Console.Clear();
        }

        private static void Main()
        {
            Scripture scripture = new Scripture(new ScriptureReference("John", 3, 16),
                "For God so loved the world that he gave his only Son, " +
                "so that everyone who believes in him may not perish but may have eternal life.");

            while (!scripture.AllWordsHidden())
            {
                Console.WriteLine("Press Enter to reveal the hidden words or type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                if (scripture.HideRandomWord())
                {
                    ClearConsole();
                    scripture.Display();
                }
                else
                {
                    break;
                }
            }
        }
    }
}

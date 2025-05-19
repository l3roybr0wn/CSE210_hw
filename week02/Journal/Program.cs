using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        Entry entry = new Entry(date, prompt, response);
                        journal.AddEntry(entry);
                        break;

                    case "2":
                        journal.Display();
                        break;

                    case "3":
                        Console.Write("Enter filename to save: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine("Journal saved.\n");
                        break;

                    case "4":
                        Console.Write("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        try
                        {
                            journal.LoadFromFile(loadFilename);
                            Console.WriteLine("Journal loaded.\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error loading file: {ex.Message}\n");
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.\n");
                        break;
                }
            }
        }
    }

    // ------------------------
    // Entry class
    // ------------------------
    class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        public override string ToString()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }

        public string ToFileString()
        {
            return $"{Date}|{Prompt}|{Response}";
        }

        public static Entry FromFileString(string line)
        {
            var parts = line.Split('|');
            return new Entry(parts[0], parts[1], parts[2]);
        }
    }
    class PromptGenerator
    {
        private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

        private Random _random = new Random();

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
    class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void Display()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No journal entries found.\n");
                return;
            }

            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.ToFileString());
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                _entries.Add(Entry.FromFileString(line));
            }
        }
    }
}

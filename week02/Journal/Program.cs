using System;

// Exceeds requirements: Each journal entry includes a mood tag. 
// Uses a unique separator for file storage. Extra prompts are included for more variety.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                // Prompt for mood to add extra information to the entry.
                Console.Write("How would you describe your mood? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.\n");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.\n");
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.\n");
            }
        }
    }
}
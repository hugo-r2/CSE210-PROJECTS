using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string menuOption = "0";
        Display display = new Display();


        Console.WriteLine("Welcome to the Journal Program!");

        while (menuOption != "5")
        {
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1. Write new Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save File");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            menuOption = Console.ReadLine();
            Console.WriteLine("");



            if (menuOption == "1")
            {
                Prompts prompts = new Prompts();
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine(prompt);

                DateTime theCurrentTime = DateTime.Now;

                Entry entry = new Entry();
                entry._newEntry = Console.ReadLine();
                entry._date = theCurrentTime.ToShortDateString();
                entry._prompt = prompt;

                Console.WriteLine("Location: ");
                entry._location = Console.ReadLine();

                Console.WriteLine("Mood/Emotion: ");
                entry._mood = Console.ReadLine();


                display._entries.Add(entry);
                Console.WriteLine("");



            }

            else if (menuOption == "2")
            {
                display.DisplayEntries();

            }

            else if (menuOption == "3")
            {
                Entry entry = new Entry();
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    string _date = parts[0];
                    string _prompt = parts[1];
                    string _newEntry = parts[2];
                    string _location = parts[3];
                    string _mood = parts[4];

                    entry._newEntry = _newEntry;
                    entry._date = _date;
                    entry._prompt = _prompt;


                    display._entries.Add(entry);
                }

            }

            else if (menuOption == "4")
            {
                Console.WriteLine("What is the name of the file?");

                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {

                    foreach (var entry in display._entries)
                    {
                        outputFile.WriteLine(entry.ToString());
                    }


                }

            }

        }
    }
}
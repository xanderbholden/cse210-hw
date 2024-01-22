using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string time = DateTime.Now.ToString("hh:mm:ss tt");
        List<string> _entries = new List<string>();

        //Initial menu options--------------------
        int? select = null;
        while (select != 6)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Current Entries");
            Console.WriteLine("3. Load Previous Journal");
            Console.WriteLine("4. Save Current Journal");
            Console.WriteLine("5. Clear Current Jounal");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do?: ");
            select = int.Parse(Console.ReadLine());

            //Jounral entry--------------------
            if (select == 1)
            {
                Entry newEntry = new Entry();
                PromptGen promptEntry = new PromptGen();
                string prompt = promptEntry.GenPrompt();
                string entry = newEntry.JournalEntry();
                _entries.Add($"{date} @ {time} - {prompt} > {entry}");
                select = null;
            }

            //Display current journal--------------------
            else if (select == 2)
            {
                foreach (string i in _entries)
                {
                    Console.WriteLine(i);
                }
            }

            //Save the current journal to file--------------------
            else if (select == 3)
            {
                SaveLoad load = new SaveLoad();
                List<string> loadedList = load.LoadFile();
                _entries.Clear();
                foreach (string l in loadedList)
                {
                    _entries.Add(l);
                }
                Console.WriteLine("Journal loaded successfully");
                select = null;
            }

            //Load previous journal--------------------
            else if (select == 4)
            {
                SaveLoad nameFile = new SaveLoad();
                string name = nameFile.NameFile();
                using (TextWriter tw = new StreamWriter(name))
                {
                    foreach (string s in _entries)
                        tw.WriteLine(s);
                }
                Console.WriteLine($"Successfully saved {name}");
                select = null;
            }

            //Clear option to remove all current journal entries--------------------
            else if (select == 5)
            {
                string answer = "";
                Console.WriteLine("Are you sure you want to delete the current journal?");
                Console.Write("This cannot be undone (yes/no)! ");
                answer = Console.ReadLine();

                //Confirms to clear current entries or not-------------------
                if (answer == "yes")
                {
                    _entries.Clear();
                    Console.WriteLine("Jounral has been removed");
                }

                else
                {
                    Console.WriteLine("Journal has been logged");
                }
            }

            //End current session-------------------
            else if (select == 6)
            {
                Console.WriteLine("Program finished. Thank you!");
            }

            //If input is under 1 or over 6--------------------
            else
            {
                Console.WriteLine("That is not the correct entry, Enter a number between 1-5.");
                select = null;
            }

        }
    }
}
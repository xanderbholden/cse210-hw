using System;
using System.Collections.Generic;
using System.IO;

class Program

//Xander Holden 
//Cse210-hw
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string time = DateTime.Now.ToString("hh:mm:ss tt");
        List<string> _entries = new List<string>();

        //Menu options-----------------
        int? select = null;
        while (select != 6)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome. Please pick your poison:");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Current Entries");
            Console.WriteLine("3. Load Previous Journal");
            Console.WriteLine("4. Save Current Journal");
            Console.WriteLine("5. Clear Current Jounal");
            Console.WriteLine("6. Quit");
            Console.Write("What do you choose?: ");
            
            select = int.Parse(Console.ReadLine());

            //Jounral entry----------------
            if (select == 1)
            {
                Entry newEntry = new Entry();
                PromptGen promptGenerator = new PromptGen();
                string entry = newEntry.JournalEntry();
                _entries.Add(entry);
            
            }

            //Display current entry----------------
            else if (select == 2)
            {
                foreach (string entry in _entries)
                {
                    Console.WriteLine(entry);
                }
            }
             //Load previous entry--------------------
            else if (select == 3)
            {
                SaveFile saveFile = new SaveFile();
                List<string> loadedEntries = saveFile.LoadEntries();
                _entries.Clear();
                foreach (string entry in loadedEntries)
                {
                    _entries.Add(entry);
                }
                Console.WriteLine("Journal loaded successfully");
            }
           //Save entry-------------------
            else if (select == 4)
            {
               string fileName = "xander.txt";
               try
               {
                    using (TextWriter tw = new StreamWriter(fileName))
                    {
                     foreach (string s in _entries) tw.WriteLine(s);
                    }
                    Console.WriteLine($" Journal entry Successfully saved {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Journal entries saving Error: {ex.Message}");
                }    
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

            //End current session------------
            else if (select == 6)
            {
                Console.WriteLine("Program finished. Thank you for the tea");
            }

            //If input is under 1 or over 6-----------------
            else
            {
                Console.WriteLine("Invalid, Please enter a number between 1-5.");
                select = null;
            }

        }
    }
}


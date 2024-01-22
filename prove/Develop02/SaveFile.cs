using System;
using System.Collections.Generic;
using System.IO;
public class SaveFile
{
    private string fileName = "xander.txt";
    public void SaveEntry(string entry)
    {
        try
        {
            using (TextWriter tw= new StreamWriter(fileName, true))
            { 
                tw.WriteLine (entry);
            }

            Console.Write($" Success! You saved your entry on {fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Mayday-Mayday! Error saving entry: {ex.Message} ");
        }
    }
    public List<string> LoadEntries()
    {
        try
        { 
            if(File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                return new List<string>(lines);
            }
            else
            {
                Console.WriteLine($"File '{fileName}' does not exist.");
                return new List<string>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failure loading entries: {ex.Message}");
            return new List<string>();
        }
    }
}
        
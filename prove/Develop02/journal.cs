using System.IO;

public class Journal
{
    public List<Entry> _entires = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entires.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entires)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter fileToSave = new StreamWriter(file))
        {
            foreach (Entry entry in _entires)
            {
                fileToSave.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile (string file)
    {
         public void LoadFromFile (string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entires.Add(newEntry);

        }
    }
}
}
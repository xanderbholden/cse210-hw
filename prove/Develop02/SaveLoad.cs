public class SaveLoad
{
    public string NameFile()
    {
        Console.Write("What would you like to name the file? >");
        string fileName = Console.ReadLine();
        return fileName;
    }

    public List<string> LoadFile()
    {
        Console.Write("Please enter the file name you wish to load: > ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        List<string> empty = new List<string>();
        foreach (string l in lines)
        {
            empty.Add(l);
        }
        return empty;
    }
}
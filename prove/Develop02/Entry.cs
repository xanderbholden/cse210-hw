public class Entry
{

    public string _userInput = "";

    public string JournalEntry()
    {
        PromptGen generate = new PromptGen();
        Console.Write(" > ");
        _userInput = Console.ReadLine();
        Console.WriteLine("Entry added");
        return _userInput;
    }

}
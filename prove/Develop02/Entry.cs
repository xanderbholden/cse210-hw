public class Entry
{

    public string UserInput = "";

    public string JournalEntry()
    {
        PromptGen generate = new PromptGen();
         string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
         string currentTime = DateTime.Now.ToString("hh:mm:ss tt");
         string prompt = generate.GenPrompt();

         Console.WriteLine($"{currentDate} @ {currentTime} - > {prompt}");
         UserInput = Console.ReadLine();

         Console.WriteLine("Entry added");
        return $"{currentDate} @ {currentTime} - {prompt} > {UserInput}";
    }
}
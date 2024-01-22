using System.Runtime.InteropServices;

public class PromptGen
{

    //Default list options--------------------
    public string GenPrompt()
    {//Manual list
        List<string> _prompts = new List<string>
        { "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        //My prompts begin here
        "What did you do today?",
        "Pick a random scripture. What does it mean to you?",
        "If you're posterity saw this entry, what would you want them to know about you?",
        "What new thing did you learn today?",
        "What was your favorite song that you heard today?",
        "Who was on your mind the most today?",
        "Tough day huh? Tell me all about it.",
        "How are you REALLY doing today?",
        "What are you thinking about literally right now?",
        "Why do you still write in your journal?",
        "Whos have you helped today?",
        "What prayer was in your heart today?" };
        Random _rnd = new Random();
        int _rngIndex = _rnd.Next(_prompts.Count);
        string _random = _prompts[_rngIndex];
        Console.Write(_random);
        return _random;
    }

}
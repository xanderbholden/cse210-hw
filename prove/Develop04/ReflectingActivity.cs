using System;

class ReflectionActivity : Activity
{
    public override void Start()
    {
        base.Start();

        Console.WriteLine("Ok time to Reflect a bit.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ");
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        int duration = GetDuration();
        int usedDuration = duration;

        Random random = new Random();
        string[] prompts = {
            " --- Think of a time when you stood up for someone else. --- ",
            " --- Think of a time when you did something really difficult. --- ",
            " --- Think of a time when you helped someone in need. --- ",
            " --- Think of a time when you did something truly selfless. --- ",
            " --- Think of a time you felt powerful --- ",
            " --- Think of a time where you felt calm --- ",
            " --- Think of a time that you could control your temper, and prevent a fight. --- ",
            " --- Think of a time that you felt completely at peace --- "
        };
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt + "\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        CountDown(5);
        foreach (string question in questions)
        {
            Console.Write(question);
            Spinner(15);
            usedDuration -= 15;
            if (usedDuration <= 0)
            {
                break;
            }
        }

        Console.WriteLine("Well done!! :) You're awesome!!\n\n You have completed another {0} seconds of the Reflecting Activity", duration);
        Spinner(3);
        Console.Clear();
    }
}

using System;

class ListingActivity : Activity
{
    public override void Start()
    {

        Random random = new Random();
        string[] prompts = 
        {
            "---What are some times that you have felt joy?---",
            "---What are some things you enjoy eating?---",
            "---What are some experiences that have helped you grow as a person?---",
            "---What are some things that make you feel grateful?---",
            "---What are some activities you enjoy doing in your free time?---",
            "---What are some things that you are curious about?---",
            "---What are some things you've done that you are proud of?---",
            "---What are some things that you've learned recently?---",
            "---What are some things that you are looking forward to?---",
            "---What are some things that inspire you?---",
            "---What are some things that you find relaxing?---",
            "---What are some things that you find challenging?---",
            "---What are some things that you find fulfilling?---",
            "---What are some things that you find frustrating?---",
            "---What are some things that you find funny?---",
            "---What are some things that you find beautiful?---",
            "---What are some things that you find meaningful?---",
            "---What are some things that you find exciting?---",
            "---What are some things that you find scary?---",
            "---What are some things that you find surprising?---",
            "---What are some things that you find confusing?---",
            "---What are some things that you find annoying?---",
            "---What are some things that you find interesting?---",
            "---What are some things that you find enjoyable?---",
            "---What are some things that you find challenging?---",
            "---What are some things that you find worthwhile?---",
            "---What are some things that you find frustrating?---",
            "---What are some things that you find rewarding?---",
            "---What are some things that you find inspiring?---",
            "---What are some things that you find humbling?---",
            "---What are some things that you find overwhelming?---",
            "---What are some things that you find peaceful?---",
            "---What are some things that you find hopeful?---",
            "---What are some things that you find motivating?---",
            "---What are some things that you find satisfying?---",
            "---What are some things that you find empowering?---",
            "---What are some things that you find fascinating?---",
            "---What are some things that you find amusing?---",
            "---What are some things that you find impressive?---",
            "---What are some things that you find heartwarming?---",
            "---What are some things that you find thought-provoking?---"
        };
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int timeLimit = GetDuration();

        DateTime deadline = DateTime.Now.AddSeconds(timeLimit);

        base.Start();

        Console.WriteLine("List as many responses as you can to the following prompt:\n\n" + prompt + "\n");
        Console.Write("You may begin in: ");
        CountDown(5);

        int x = 0;
        while (DateTime.Now < deadline)
        {
            Console.Write("> ");
            Console.ReadLine();
            x++;
        }

        Console.WriteLine("Well done!! :) You're Finished!! \n\n You have listed " + x + " items.");
        Spinner(3);
        Console.Clear();
    }
}
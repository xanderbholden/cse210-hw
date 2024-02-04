using System;

class BreathingActivity : Activity
{
    public override void Start()
    {
        base.Start();

        Console.WriteLine("Lets begin with a Breathing Activity.\n");
        Console.Write("This section of the program will help you relax by walking you through a breathing exercise. Clear your mind and follow the prompts.\n\n How long, in seconds, would you like for your session? ");
        int duration = GetDuration();
        int total = duration;
        while (duration > 0)
        {
            Console.Write("Breathe in...");
            CountDown(4);

            Console.Write("Hold it...");
            CountDown(7);

            Console.Write("Breathe out...");
            CountDown(8);
            Console.WriteLine("");
            duration -= 19;
        }

        Console.WriteLine($"Well done!! :) You're awesome!!\n\n You have completed another {total} seconds of the Breathing Activity.");
        Spinner(3);
        Console.Clear();
    }
}

// Xander Holden 
//Cse-210
//Week 4
//Mindfulness


using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        int choice;
        string input;
        while (loop)
        {
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start Reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity bActivity = new BreathingActivity();
                        bActivity.Start();
                        break;
                    case 2:
                        Console.Clear();
                        ReflectionActivity rActivity = new ReflectionActivity();
                        rActivity.Start();
                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity lActivity = new ListingActivity();
                        lActivity.Start();
                        break;
                    case 4:
                        Console.Clear();
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }

    static int GetDuration()
    {
        int duration;
        while (true)
        {
            Console.Write("Enter the desired duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer value.");
        }
    }
}

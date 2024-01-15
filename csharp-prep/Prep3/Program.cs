using System;

class Program
{
    static void Main(string[] args)
    {

    {
    
        
       
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Go Up!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Go Down!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}
    }
}
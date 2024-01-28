using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Reference theReference1 = new Reference("1 Nephi", 3, 7);
        Reference theReference2 = new Reference("Alma", 36, 3);
        Reference theReference3 = new Reference("Philippians", 4, 13);
        Reference theReference4 = new Reference("Jeremiah", 29, 11);

       
        Scripture theScripture1 = new Scripture(theReference1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Scripture theScripture2 = new Scripture(theReference2, "And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.");
        Scripture theScripture3 = new Scripture(theReference3, "I can do all things through Christ which strengtheneth me.");
        Scripture theScripture4 = new Scripture(theReference4, "For I know the thoughts that I think toward you, saith the Lord, thoughts of peace, and not of evil, to give you an expected end.");

    
        List<Scripture> scriptures = new List<Scripture> { theScripture1, theScripture2, theScripture3, theScripture4 };

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Scripture randomScripture = scriptures[index];

        Console.WriteLine(randomScripture.Reference.GetDisplayText());
        Console.WriteLine(randomScripture.GetDisplayText());

        Console.Write("\nPress 'h' to hide a word\nType 'quit' to quit\nType 'save' to save\nType 'l' to load from file: ");
        string input = Console.ReadLine();

     while (input.ToLower() != "quit" && !randomScripture.IsCompletelyHidden())
    
     {
    
    randomScripture.HideRandomWord(4);

    
    Console.Clear();
    Console.WriteLine(randomScripture.Reference.GetDisplayText());
    Console.WriteLine(randomScripture.GetDisplayText());

    
    Console.Write("\nPress 'h' to hide a word\nType 'quit' to exit\nType 's' to save\nType 'l' to load from file: ");
    input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        Console.WriteLine("Thank You for Using Mashter Scripture. Goodbye!");
        break;
    }
    else if (input.ToLower() == "save")
    {
        Console.Write("Enter file name to save: ");
        string saveFile = Console.ReadLine();
        randomScripture.SaveFile(saveFile);
    }
    else if (input.ToLower() == "load")
    {
        Console.Write("Enter file name to load from: ");
        string loadFile = Console.ReadLine();
        randomScripture.LoadFile(loadFile);
    }  
    }
    }
 }
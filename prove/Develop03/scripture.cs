using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;


public class Scripture 
{
    private  Reference _reference;
    private static Random random = new Random();
    private List<Word> _words;
    public Reference Reference
    {
        get 
        { 
            return _reference;
        }
    }
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();              // Creating a new instance of the List<Word> class and assigning to the _words 
        string[] words = text.Split(' ');       //Split the text by spaces and create a word object for each word
        foreach (string word in words)
        {
            _words.Add(new Word(word));        // create a new Word object _words.Add(word); // add it to the list
        }
    }

    public void HideRandomWord(int numberToHide)
    {
        int count = 0;
        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide(); 
            count++; 
        }
    }
    public string GetDisplayText()
    {
       string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";  
        }
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void SaveFile(string file)
    {   
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine($"{_reference.GetDisplayText()}");

                foreach (Word word in _words)
                {
                    writer.WriteLine(word.GetDisplayText());
                }
            }
        }
        catch (IOException ex)
        {
        Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }
   public void LoadFile(string file)
    {
       try
       {
            string[] lines = System.IO.File.ReadAllLines(file);
            if (lines.Length > 0)
            {

                string[] referenceParts = lines[0].Split(' ');
                string book = referenceParts[0];
                int chapter = int.Parse(referenceParts[1].Split(':')[0]);
                string[] verses = referenceParts[1].Split(':')[1].Split('-');
                int startVerse = int.Parse(verses[0]);
                int endVerse = verses.Length > 1 ? int.Parse(verses[1]) : startVerse;

                _reference = new Reference(book, chapter, startVerse, endVerse);

                _words = new List<Word>();
                for (int i = 1; i < lines.Length; i++)
                {
                    _words.Add(new Word(lines[i]));
                }
            }
            
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}
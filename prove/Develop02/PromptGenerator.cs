using System.Reflection.Metadata.Ecma335;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        PromptGenerator initialPrompts = new PromptGenerator();

        initialPrompts._prompts.Add("What was your biggest regret today?");
        initialPrompts._prompts.Add("What was something you did today that got you closer to reaching a goal?");
        
        initialPrompts._prompts.Add("Who had the biggest influence on you today and why?");
        initialPrompts._prompts.Add("What prayer has been in your heart today?");
        initialPrompts._prompts.Add("What is a way the Lord has helped you today?");
        initialPrompts._prompts.Add("What person have you helped today?");

        Random randomGenerator = new Random();
        int randomPromptIndex = randomGenerator.Next(1,initialPrompts._prompts.Count());
        string randomPrompt = initialPrompts._prompts[randomPromptIndex];
        
        return randomPrompt;
    }
}
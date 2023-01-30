using System;
public class Entry
{
    public string _userResponse;
    public List<string> _prompts = new List<string>();

    
    public string DisplayPrompt(){
        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, 2);
        Console.WriteLine($"Your prompt today is {_prompts[indexNumber]}");
        _userResponse = Console.ReadLine();
        return _userResponse;
    }
}
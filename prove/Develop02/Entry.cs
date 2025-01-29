

using System.Runtime.InteropServices.Marshalling;

public class Entry

{
    //attributes
    public string _dateTime;
    public string _userInput;
    public List<string> _allPrompts = new List<string>() {"What was the high and low of your day?\n>", "Where did you see the hand of the Lord in your day?\n>", "What were you successful with today and what could use some imporvement?\n>","Did you meet anyone new? Where and how?\n>","What were your goals for today? Did you accomplish them?\n>","What is one thing you noticed today that you love/like about yourself?\n>","Did you serve anyone today? Did anyone serve you?\n>"};
    int _index;
    public Random rnd = new Random();
    

    public void DisplayPrompt()
    {
        _index = rnd.Next(_allPrompts.Count);
        Console.Write(_allPrompts.ElementAt(_index));
        _userInput = Console.ReadLine();

    }
    public void DisplayEntry()
    {
        _dateTime = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(_dateTime);
        Console.WriteLine($"Prompt: {_allPrompts.ElementAt(_index)}");
        Console.WriteLine(_userInput);
    }

    public string FormatEntryForSave()

    {
        return $"{_dateTime},{_allPrompts.ElementAt(_index)},{_userInput}";
    }
}
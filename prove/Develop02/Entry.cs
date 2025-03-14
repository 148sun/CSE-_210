

using System.Runtime.InteropServices.Marshalling;

public class Entry

{
    //attributes
    public string _dateTime;
    public string _userInput;
    public List<string> _allPrompts = new List<string>()
    {
        "What was the high and low of your day?",
        "Where did you see the hand of the Lord in your day?",
        "What were you successful with today and what could use some improvement?",
        "Did you meet anyone new? Where and how?",
        "What were your goals for today? Did you accomplish them?",
        "What is one thing you noticed today that you love/like about yourself?",
        "Did you serve anyone today? Did anyone serve you?",
        "What are you looking forward to for today or tomorrow?"
    };
    int _index;
    public Random rnd = new Random();
    public string _myPrompt;


    public void DisplayPrompt()
    {
        _index = rnd.Next(_allPrompts.Count);
        _myPrompt = _allPrompts.ElementAt(_index);
        Console.Write(_myPrompt);
        Console.Write("\n>");
        _userInput = Console.ReadLine();

    }
    public void DisplayEntry()
    {

        Console.WriteLine(_dateTime);
        Console.WriteLine($"Prompt: {_myPrompt}");
        Console.WriteLine(_userInput);
        Console.WriteLine();
    }
    public void DisplayLoadedEntry()
    {
        Console.WriteLine(_dateTime);
        Console.WriteLine($"Prompt: {_myPrompt}");
        Console.WriteLine(_userInput);
        Console.WriteLine();
    }


    public string FormatEntryForSave()

    {
        return $"{_dateTime}|{_myPrompt}|{_userInput}";
    }
    
}
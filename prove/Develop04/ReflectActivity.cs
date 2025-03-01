using System.Diagnostics.CodeAnalysis;

public class ReflectActivity : Activity
{
    //Attribute


    private List<string> _promptList = new List<string>()
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need",
    "Think of a time when you did something truly selfless."
    };

    private List<string> _questionList = new List<string>()
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };
    private Random rnd = new Random();

    //Constructor
    public ReflectActivity(string name) : base(name)
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //Methods
    private void DisplayPrompt()
    {
        int _index = rnd.Next(_promptList.Count);
        string _myPrompt = _promptList.ElementAt(_index);
        Console.Write($"---{_myPrompt}---");


    }
    private void DisplayReflectQuestion()
    {
        int _index = rnd.Next(_questionList.Count);
        string _myQuestion = _questionList.ElementAt(_index);
        Console.WriteLine($"> {_myQuestion}");
        Spinner(5);


    }

    public void Reflect()
    {
        Console.WriteLine("\n\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue. ");
        string _ready = Console.ReadLine();
        if (_ready == "")
        {
            Console.WriteLine("\n\nNow ponder on each of the following questions as they relate to this experience.");
            BeginMessage();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_time);
            Console.Clear();
            Console.Write("\n");
            while (startTime < futureTime)
            {

                DisplayReflectQuestion();
                startTime = DateTime.Now;
            }








        }

    }

}
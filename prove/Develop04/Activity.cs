

public class Activity
{
    // Attributes
    private int _option;
    protected int _time;
    private string _name;

    protected string _description;


    // Constructor
    public Activity(string name)
    {
        _name = name;
    }

    // Methods

    public void Option()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Start Guided Activity\n5. Quit");
        Console.Write("Select a choice from the menu: ");
        _option = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    public void Welcome()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);

    }
    public int GetOption()
    {
        return _option;
    }
    public void GetTime()
    {
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void GetReady()
    {
        Console.WriteLine("Get Ready...");
        Spinner(3);
    }
    public void BeginMessage()
    {
        Console.Write("\n\nYou May Begin in: ");
        for (int i=5; i>0; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");   
        }

    }
    public void Spinner(int _seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);

        

        while (DateTime.Now < futureTime)
        {
            Console.Write("\b\b");
            Console.Write("/");
            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("|");
            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");
            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("-");
            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("/");
            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("|");
            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");

            
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("-");

            Thread.Sleep(500);

    }
    Console.Write("\b \b");
    }

    public void Clock(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Goodbye()
    {
        Console.WriteLine("\n\n Well done!!");
        Spinner(3);
        Console.WriteLine($"\n\nYou have completed another {_time} seconds of the {_name}!");
        Spinner(3);
    }

}
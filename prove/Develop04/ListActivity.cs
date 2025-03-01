public class ListActivity : Activity
{
    //Attribute
    private List<string> _promptList = new List<string>() 
    {"Who are people that you appreciate? ", 
    "What are personal strengths of yours? ",
    "What are people that you have helped this week ",
    "When have you felt the Holy Ghost this month? ",
    "Who are some of your personal heroes? "
    };
    private Random rnd = new Random();



    //constructor
    public ListActivity(string name) : base(name)
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    //Methods
    private void DisplayPrompt()
    {
        int _index = rnd.Next(_promptList.Count);
        string _myPrompt = _promptList.ElementAt(_index);
        Console.Write($"---{_myPrompt}---");
        
    }
    public void Listing()
    {
        Console.WriteLine("List as many responses you can to the folowing prompt:");
        DisplayPrompt();
        BeginMessage();
          DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_time);
            Console.Clear();
            Console.Write("\n");
            DisplayPrompt();
            while (startTime < futureTime)
            {

               Console.Write("\n> ");
               Console.ReadLine();

                startTime = DateTime.Now;
            }


    }
    
}
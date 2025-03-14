public class Simple : Goal
{
    //Attributes
    private bool _status;
    private string _checked;

    //Constructor
    

    public Simple(string name, string goal, int points, int score, bool status) : base(name, goal, points)
    {
        _status = status;
        _score = score;
        _checked = " ";
    }

    //Method
    public override void Display()
    {
         if (_status)
         {
            _checked = "X";
            
         }
        Console.Write($"[{_checked}] Simple Goal: {_name} ({_goal})");
        
    }

        public override string FormatEntry() 
    {
        return $"Simple Goal:{_name}|{_goal}|{_points}|{_score}|{_status}";
        
    }
    public override void RecordEvent()
    {
        Console.Write($"Have you completed your {_name} goal?  [Input 1 for Yes and 0 for No]? ");
        if (int.Parse(Console.ReadLine())==1)
        {
            _status = true;
            _score = _points;
            Console.Write($"Nice work! In total you have earned {_score} towards {_name} goal!");
        }
        else
        {
            Console.Write("Just keep swimming (figuratively)!!");
        }
        
    }
}
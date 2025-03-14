public class Checklist : Goal
{
    //attributes

    private int _bonus;
    private int _completed;
    private int _outOf;
    private string _checked;


    //Constructor
    public Checklist(string name, string goal, int points, int bonus, int outOf, int completed, int score) : base(name, goal, points)
    {

        _bonus = bonus;
        _completed = completed;
        _outOf = outOf;
        _score = _completed;
        _checked = " ";
    }

    //methods
    public override void Display()
    {
        if (_completed == _outOf)
        {
            _checked = "X";

        }
        Console.Write($"[{_checked}] Checklist Goal: {_name} ({_goal}) --- Currently completed: {_completed}/{_outOf}");


    }
    public override string FormatEntry()
    {
        return $"Checklist Goal:{_name}|{_goal}|{_points}|{_bonus}|{_outOf}|{_completed}|{_score}";

    }
    public override void RecordEvent()
    {

        Console.Write($"Have you completed your {_name} goal?  [Input 1 for Yes and 0 for No]? ");
        int yes_no = int.Parse(Console.ReadLine());

        if (yes_no == 1)
        {
            
            if (_completed == _outOf)
            {
                Console.Write("You have completed this goal! I suggest creating another checklist goal! ");
            }

            else
            {
                
                _completed += 1;
                
                _score += _points;
                if (_completed == _outOf)
                {
                    _score += _bonus;
                   
                }

                    Console.Write($"Nice work! In total you have completed your goal {_completed} out of {_outOf} times. You have earned {_score} towards {_name} goal!");

            }

        }
        else
        {
            Console.Write("Just keep swimming (figuratively)!!");
        }



    }




}
public class Ongoing : Goal
{
    //Attributes

    //Constructor
    public Ongoing(string name, string goal, int points, int score) : base(name, goal, points)
    {
        _score = score;

    }
    //Method
    public override void Display()
    {
        Console.Write($"[-] Ongoing Goal: {_name} ({_goal})");
    }

    public override string FormatEntry()
    {
        return $"Ongoing Goal:{_name}|{_goal}|{_points}|{_score}";

    }

    public override void RecordEvent()
    {
        
        Console.Write($"Have you completed your {_name} goal?  [Input 1 for Yes and 0 for No]? ");
        if (int.Parse(Console.ReadLine()) == 1)
        {

            _score += _points;
            Console.Write($"Nice work! In total you have earned {_score} towards {_name} goal!");
        }
        else
        {
            Console.Write("Keep going! You've got this!! ");
        }


    }
}
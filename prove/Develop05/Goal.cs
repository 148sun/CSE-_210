using System.Dynamic;

public abstract class Goal
{
    //attributes
    protected string _name;
    protected string _goal;
    protected int _points;
    protected int _score;

    //Constructor
    public Goal(string name, string goal, int points)
    {
        _name = name;
        _goal = goal;
        _points = points;
        _score = 0;
    }

    //Methods
    public abstract void Display();




    public abstract void RecordEvent();

    public abstract string FormatEntry();

    public int GetScore()
    {
        return _score;
    }

}
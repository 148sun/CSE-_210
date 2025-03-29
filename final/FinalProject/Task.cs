public class Task
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _time;
    protected bool _status;
    protected string _checked;

    //Constructor
    public Task(string name, string description, int time, bool status)
    {
        _name = name;
        _description = description;
        _time = time;
        _status = status;
        
    }
    //Methods
    public virtual void Display()
    {
        
        if (_status)
        {
            _checked = "X";
        }
        else
        {
            _checked = " ";

        }
        Console.Write($"{_name} [{_checked}] ");
    }
    public virtual void Description()
    {
        Console.Write($"{_name}: ({_time}), {_description})");
    }
    
}
using Microsoft.Win32.SafeHandles;

public class Assignment : Task
{
    //Attributes
    private string _dueDate;
    private string _className;

    //Constructor
    public Assignment(string name, string description, int time, bool status, string className, string dueDate) : base(name, description, time, status)
    {
        _className = className;
        _dueDate = dueDate;
    }

    //Methods
    public override void Display()
    {
                if (_status)
        {
            _checked = "X";
        }
        else
        {
            _checked = " ";

        }
        Console.Write($"{_name}({_className}) [{_checked}] ");
        
    }

    public override void Description()
    {
        Console.Write($"{_className}\n{_dueDate} {_name}: ({_time}), {_description})");

    }

}
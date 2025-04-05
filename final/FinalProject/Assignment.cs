using Microsoft.Win32.SafeHandles;

public class Assignment : Task
{
    //Attributes
    private string _dueDate;
    private string _className;
    

    //Constructor
    public Assignment(string name, string description, int time, string className, string dueDate) : base(name, description, time)
    {
        _className = className;
        _dueDate = dueDate;
        
    }

    //Methods
    public override string Display()
    {

        return $"\n{_name}({_className}), ({_time})";
        
    }

    public override void Description()
    {
        Console.Write($"{_className}\n{_dueDate} {_name}: ({_time}), {_description})");

    }

}
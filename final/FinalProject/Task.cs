public class Task
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _time;
    

    //Constructor
    public Task(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
        
        
    }
    //Methods
    public virtual string Display()
    {
        
        return $"\n{_name} ({_time})";
    }
    public virtual void Description()
    {
        Console.Write($"\n{_name}: ({_time}), {_description})");
    }
    public int SendTime()
    {
        return _time;
    }
    
}
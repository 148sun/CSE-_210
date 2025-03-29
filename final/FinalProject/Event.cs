public class Event
{
    //Attributes
    protected TimeOnly _start;
    protected TimeOnly _end;
    protected string _location;
    protected string _name;

    //Constructor
    public Event(string name, string location, string start, string end)
    {
        _start = TimeOnly.Parse(start);
        _end = TimeOnly.Parse(end);
        _location = location;
        _name = name;

    }

    //Method
    public virtual string Display()
    {
        return $"{_start}-{_end}, {_name}, {_location}";
    }
    public TimeOnly GetStart()
    {
        return _start;
    }

    public TimeOnly GetEnd()
    {
        return _end;
    }

    public string GetName()
    {
        return _name;
    }


}
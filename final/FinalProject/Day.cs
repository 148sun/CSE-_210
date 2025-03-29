public class Day
{

    //attributes
    private string _date;
    TimeOnly _start;
    TimeOnly _end;
    TimeOnly _lunchStart;
    TimeOnly _lunchEnd;
    private List<Task> _taskList = new List<Task>();
    private List<Class> _classList = new List<Class>();
    private List<Event> _eventList = new List<Event>();
    string _dayPlan;
    List<Event> _sortedEvents = new List<Event>();
    List<TimeSpan> _timeSpanList = new List<TimeSpan>();

    //Constructor
    public Day(string date, string start, string end, string lunchStart, string lunchEnd)
    {
        _date = date;
        _start = TimeOnly.Parse(start);
        _end = TimeOnly.Parse(end);
        _lunchStart = TimeOnly.Parse(lunchStart);
        _lunchEnd = TimeOnly.Parse(lunchEnd);
        Event Lunch = new Event("Lunch", "---", lunchStart, lunchEnd);

        _eventList.Add(Lunch);




    }

    //Methods
    
    public void CreateDayPlan()
    {






        // Sort events by StartTime first, then EndTime
        _sortedEvents = _eventList.OrderBy(e => e.GetStart()).ThenBy(e => e.GetEnd()).ToList();
        _timeSpanList.Clear();
        for (int i=0; i < _sortedEvents.Count-1; i++)
        {
            TimeSpan span = _sortedEvents[i].GetEnd()-_sortedEvents[i+1].GetStart();
            _timeSpanList.Add(span);
        }

        // foreach (Event ev in _sortedEvents)
        // {
        //     Console.WriteLine($"{ev.GetStart()}-{ev.GetEnd()} {ev.GetName()}");
        // }



    }



    public void DisplayDayPlan()
    {
        if (_sortedEvents[0].GetStart().Equals(_start) == false)
        {
            Console.Write($"{_start}\n");
        }

        //Console.Write(_start);
        
        for (int j=0; j < _sortedEvents.Count(); j++)
        {
            Console.Write($"{j+1}. {_sortedEvents[j].Display()}\n");
           
            

        }

        if (_sortedEvents.Last().GetEnd().Equals(_end) == false)
        {
            Console.Write(_end);
        }
        foreach (TimeSpan span in _timeSpanList)
        {
            Console.Write($"{span.Minutes}\n");
        }


    }

    public void AddTask(Task task)
    {
        _taskList.Add(task);

    }
    public void AddClass(Class _class)
    {
        _classList.Add(_class);
    }
    public void AddEvent(Event _event)
    {
        _eventList.Add(_event);
    }

    public void SaveDayPlan()
    {

    }

}
using System.Dynamic;
using System.Globalization;

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
    private List<string> _dayPlan = new List<string>();
    List<Event> _sortedEvents = new List<Event>();
    //List<TimeSpan> _timeSpanList = new List<TimeSpan>();
    List<int> _tasksIndex = new List<int>();
    List<string> _dayPlanList = new List<string>();

    //Constructor
    public Day()
    {
        _date = " ";
        _start = TimeOnly.Parse("6:00 AM");
        _end = TimeOnly.Parse("6:00 PM");
        _lunchStart = TimeOnly.Parse("12:15 PM");
        _lunchEnd = TimeOnly.Parse("12:45 PM");


    }
    //Methods
    public void SetVariables(string date, string start, string end, string lunchStart, string lunchEnd)
    {
        _date = date;
        _start = TimeOnly.Parse(start);
        _end = TimeOnly.Parse(end);
        _lunchStart = TimeOnly.Parse(lunchStart);
        _lunchEnd = TimeOnly.Parse(lunchEnd);
        Event Lunch = new Event("Lunch", "---", lunchStart, lunchEnd);

        _eventList.Add(Lunch);




    }







    public void DisplayDayPlan()
    {
        Console.WriteLine($"\nDay Plan for {_date}");
        _dayPlanList.Add($"\nDay Plan for {_date}");
        Console.WriteLine();

        //TRY SOMETHING NEW
        _dayPlan.Clear();
        //_timeSpanList.Clear();
        _sortedEvents.Clear();
        _dayPlanList.Clear();





        int eventIndex = 0;
        // Sort events by StartTime first, then EndTime
        _sortedEvents = _eventList.OrderBy(e => e.GetStart()).ThenBy(e => e.GetEnd()).ToList();

        Console.Write($"{eventIndex++}. {_start}");
        _dayPlanList.Add($"{eventIndex}. {_start}");


        //Create a list of the span times
        TimeSpan spanStart = _sortedEvents[0].GetStart() - _start;
        List<Task> intermediate0 = new List<Task>();
        List<Task> intermediatei = new List<Task>();
        


        foreach (int a in _tasksIndex)
        {
            if (a == 0)
            {
                intermediate0.Clear();
                intermediate0.Add(_taskList[_tasksIndex.IndexOf(a)]);
                spanStart -= TimeSpan.FromMinutes(_taskList[_tasksIndex.IndexOf(a)].SendTime());
            }

        }
        foreach (Task task in intermediate0)
        {
            Console.Write(task.Display());
            _dayPlanList.Add(task.Display());
        }
        if (spanStart != TimeSpan.Zero)
        {
            Console.Write($"\n{spanStart.TotalMinutes} min");
            _dayPlanList.Add($"\n{spanStart.TotalMinutes} min");
        }

        TimeSpan span;
        for (int i = 0; i < _sortedEvents.Count(); i++)
        {
            

            Console.Write($"\n{eventIndex++}. {_sortedEvents[i].Display()}");
            _dayPlanList.Add($"\n{eventIndex}. {_sortedEvents[i].Display()}");
            if (i + 1 == _sortedEvents.Count())
            {
                span = _end - _sortedEvents[^1].GetEnd();

            }
            else
            {
                span = _sortedEvents[i + 1].GetStart() - _sortedEvents[i].GetEnd();

            }

            foreach (int a in _tasksIndex)
            {
                if (a == i+1)
                {
                    intermediatei.Clear();
                    intermediatei.Add(_taskList[_tasksIndex.IndexOf(a)]);
                    span -= TimeSpan.FromMinutes(_taskList[_tasksIndex.IndexOf(a)].SendTime());
                }

            }
            foreach (Task task in intermediatei)
            {
                Console.Write(task.Display());
                _dayPlanList.Add(task.Display());
            }
            intermediatei.Clear();
            if (span != TimeSpan.Zero)
            {
                Console.Write($"\n{span.TotalMinutes} min");
                _dayPlanList.Add($"\n{span.TotalMinutes} min");
            }

        }
        Console.Write($"\n{_end}");
        _dayPlanList.Add($"\n{_end}");
        Console.WriteLine();
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
    public void AddTaskIndex(int index)
    {
        _tasksIndex.Add(index);
    }
    public List<string> GetList()
    {
        return _dayPlanList;
    }

    public void SaveDayPlan()
    {

        Console.Write("Please input the filename you would like to save your day plan to: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in _dayPlanList)
            {
                outputFile.WriteLine(line);


            }
        }


    }


}


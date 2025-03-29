namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        using System;
using System.Collections.Generic;
using System.Linq;

class Event
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}

class Program
{
    static void Main()
    {
        var events = new List<Event>
        {
            new Event { StartTime = new TimeOnly(10, 0), EndTime = new TimeOnly(12, 0) },
            new Event { StartTime = new TimeOnly(8, 30), EndTime = new TimeOnly(9, 30) },
            new Event { StartTime = new TimeOnly(13, 15), EndTime = new TimeOnly(14, 15) }
        };

        // Sort events by StartTime first, then EndTime
        var sortedEvents = events.OrderBy(e => e.StartTime).ThenBy(e => e.EndTime).ToList();

        foreach (var ev in sortedEvents)
        {
            Console.WriteLine($"Start: {ev.StartTime}, End: {ev.EndTime}");
        }
    }
}

    }
}

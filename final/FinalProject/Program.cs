using System;

class Program
{
    static void Main(string[] args)
    {
        Event event1 = new Event("BIO 180", "campus", "8:00 AM", "9:00 AM");
        Event event2 = new Class("Bayesian", "campus", "12:45 PM", "1:45 PM", "Johnson");
        Event event3 = new Event("Run", "outside", "6:00 PM", "7:00 PM");
        Day day1 = new Day("03/28/25", "6:00 AM", "6:00 PM", "12:15 PM", "12:40 PM");
        day1.AddEvent(event1);
        day1.AddEvent(event2);
        day1.AddEvent(event3);

        day1.CreateDayPlan();
        day1.DisplayDayPlan();
    }
}
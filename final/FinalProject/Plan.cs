public class Plan
{
    //Attributes
    private List<Day> _listDays = new List<Day>();

    //Method
    public void Display()
    {
        foreach (Day day in _listDays)
        {
            day.DisplayDayPlan();
        }
    }
    public void CreatePlan()
    {
        Day day = new Day();
        Console.Write("How many days would you like to plan for this week? "); int daysToPlan = int.Parse(Console.ReadLine());
        for (int b = 0; b < daysToPlan; b++)
        {
            //Create Day Plan

            Console.Write("Insert the following information: \nDate: "); string date = Console.ReadLine();
            Console.Write("Start: (hh:mm AM or PM) "); string start = Console.ReadLine();
            Console.Write("End: (hh:mm AM or PM) "); string end = Console.ReadLine();
            Console.Write("Lunch Start: (hh:mm AM or PM) "); string lunchStart = Console.ReadLine();
            Console.Write("Lunch End: (hh:mm AM or PM) "); string lunchEnd = Console.ReadLine();
            day.SetVariables(date, start, end, lunchStart, lunchEnd);
            Console.Write("Would you like to add events(1) or classes(2)?");
            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Console.Clear();
                Console.Write("How many events would you like to add? "); int eventTotal = int.Parse(Console.ReadLine());
                for (int i = 0; i < eventTotal; i++)
                {
                    Console.Write($"Name{i + 1}: "); string name = Console.ReadLine();
                    Console.Write($"Location{i + 1}: "); string location = Console.ReadLine();
                    Console.Write($"Start{i + 1}: (hh:mm AM or PM) "); string startTime = Console.ReadLine();
                    Console.Write($"End{i + 1}: (hh:mm AM or PM) "); string endTime = Console.ReadLine();




                    Event _event = new Event(name, location, startTime, endTime);

                    day.AddEvent(_event);
                }
            }
            if (response == 2)
            {
                Console.Write("How many classes would you like to add? "); int classTotal = int.Parse(Console.ReadLine());
                for (int i = 0; i < classTotal; i++)
                {
                    Console.Write($"Name{i + 1}: "); string name = Console.ReadLine();
                    Console.Write($"Professor Name{i + 1}: "); string professor = Console.ReadLine();
                    Console.Write($"Location{i + 1}: "); string location = Console.ReadLine();
                    Console.Write($"Start{i + 1}: (hh:mm AM or PM) "); string startTime = Console.ReadLine();
                    Console.Write($"End{i + 1}: (hh:mm AM or PM) "); string endTime = Console.ReadLine();




                    Class _class = new Class(name, location, startTime, endTime, professor);

                    day.AddClass(_class);


                }

            }
            _listDays.Add(day);



        }


    }

    public void SavePlan()
    {
        
        Console.Write("Please input the filename you would like to save your plan to: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Day day in _listDays)
            {
                List<string> list = day.GetList();
                foreach (string item in list)
                {
                    outputFile.WriteLine(item);

                }
                


            }
        }

    }




}
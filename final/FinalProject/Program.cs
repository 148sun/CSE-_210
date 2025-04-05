using System;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        Day day = new Day();
        Plan plan = new Plan();

        int _option;

        do
        {
            Console.Write("\nWhat would you like to do today?\n1. Create a Day Plan\n2. View Day Plan\n3. Edit Day Plan\n4. Create Week Plan\n5. View Week Plan\n6. Save\n7. Study\n8.Quit\nInput choice: ");
            _option = int.Parse(Console.ReadLine());
            //Console.Clear();
            if (_option == 1)
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



            }
            if (_option == 2)
            {
                
                day.DisplayDayPlan();
            }
            if (_option == 3)
            {
                //Edit Day Plan
                day.DisplayDayPlan();
                Console.Write("Would you like to add a task(1) or assignment(2)? "); int add = int.Parse(Console.ReadLine());
                if (add == 1)
                {
                    Console.WriteLine("After which event/class would you like to add a task to? [insert a number]"); int addAfter = int.Parse(Console.ReadLine());
                    day.AddTaskIndex(addAfter);
                    Console.WriteLine("What task would you like to complete? "); string taskName = Console.ReadLine();
                    Console.WriteLine("Input any description: "); string description = Console.ReadLine();
                    Console.WriteLine("How long will this task take in minutes? "); int time = int.Parse(Console.ReadLine());

                    Task task = new Task(taskName, description, time);
                    day.AddTask(task);

                }
                if (add == 2)
                {
                    Console.WriteLine("After which event/class would you like to add an assignment to? [insert a number] "); int addAfter = int.Parse(Console.ReadLine());
                    day.AddTaskIndex(addAfter);
                    Console.WriteLine("What assignment would you like to complete? "); string name = Console.ReadLine();
                    Console.WriteLine("Input any description: "); string description = Console.ReadLine();
                    Console.WriteLine("How long will this assignment take? "); int time = int.Parse(Console.ReadLine());
                    Console.WriteLine("Professor: "); string professor = Console.ReadLine();
                    Console.WriteLine("Due Date: "); string dueDate = Console.ReadLine();

                    Assignment assignment = new Assignment(name, description, time, professor, dueDate);
                    day.AddTask(assignment);

                }

            }
            if (_option == 4)
            {
                
                plan.CreatePlan();


            }
            if (_option == 5)
            {
                plan.Display();

            }
            if (_option == 6)
            {
                //Save
                Console.Write("Would you like to save your day plan(1) or your week plan(2)? "); int save = int.Parse(Console.ReadLine());
                if (save == 1)
                {
                    day.DisplayDayPlan();
                    day.SaveDayPlan();
                }
                if (save == 2)
                {
                    plan.Display();
                    plan.SavePlan();
                    
                }

            }
            if (_option == 7)
            {
                Console.Write("Would you like to memorize(1) or understand(2)? "); int study = int.Parse(Console.ReadLine());
                if (study == 1)
                {
                    Console.Write("What is the main idea of your study material? "); string main = Console.ReadLine();
                    Memorize memorize = new Memorize(main);
                    
                    memorize.GetMaterial();
                    Console.Clear();
                    Console.Write("How many times would you like to practice? "); int frequency = int.Parse(Console.ReadLine());
                    memorize.Practice(frequency);

                }
                if (study == 2)
                {
                    Console.Write("What is the main idea of your study material? "); string main = Console.ReadLine();
                    Understand understand = new Understand(main);
                    
                    understand.GetMaterial();
                    Console.Clear();
                    Console.Write("How many times would you like to practice? "); int frequency = int.Parse(Console.ReadLine());
                    understand.Practice(frequency);

                }
            }



        } while (_option != 8);


    }
}

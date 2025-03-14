using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        do
        {
            
            menu.TotalScore();
            menu.Level();
            menu.DisplayMenu();
            int _option = menu.GetOption();
            if (_option == 1)
            {
                menu.PickGoal();
                int goalOption = menu.GetGoalChoice();

                if (goalOption == 1)
                {
                    Console.Write("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goal = Console.ReadLine();

                    Console.Write("What is the amount of points associated with your goal? ");
                    int points = int.Parse(Console.ReadLine());


                    //simple goal
                    Simple simple = new Simple(name, goal, points, 0, false);
                    menu.AddGoal(simple);


                }
                if (goalOption == 2)
                {
                    //Ongoing goal

                    Console.Write("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goal = Console.ReadLine();

                    Console.Write("What is the amount of points associated with your goal? ");
                    int points = int.Parse(Console.ReadLine());



                    Ongoing ongoing = new Ongoing(name, goal, points, 0);
                    menu.AddGoal(ongoing);
                }
                if (goalOption == 3)
                {
                    //Checklist goal
                    Console.Write("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goal = Console.ReadLine();

                    Console.Write("What is the amount of points associated with your goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be compelted for a bonus? ");
                    int outOf = int.Parse(Console.ReadLine());
                    Console.Write($"What is the bonus for accomplishing it {outOf} times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    //simple goal
                    Checklist checklist = new Checklist(name, goal, points, bonus, outOf, 0, 0);
                    menu.AddGoal(checklist);
                }
            }
            if (_option == 2)
            {
                menu.DisplayGoals();
            }
            if (_option == 3)
            {
                menu.Save();
            }
            if (_option == 4)
            {
                menu.Load();
            }
            if (_option == 5)
            {
                //Track Event
                menu.TrackGoal();

            }
        } while (menu.GetOption() != 6);


    }
}
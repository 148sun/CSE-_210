using System.Dynamic;

public class Menu
{
    //attributes
    private List<Goal> _goalList = new List<Goal>();
    private int _option;
    private int _goalChoice;
    private int _totalScore;
    private string _level;
    private int _pointsLeft;

    //Constructor
    public Menu()
    {
        _option = 0;
        _goalChoice = 0;
        _totalScore = 0;



    }

    //Methods
    public void DisplayMenu()
    {

        Console.Write("\nMenu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the Menu: ");
        _option = int.Parse(Console.ReadLine());


    }

    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
    }

    public void PickGoal()
    {
        Console.Write("\nThe types of Goals are:\n 1. Simple Goal\n 2. Ongoing Goal\n 3. Checklist Goal\nWhich type of goal would you like to create? ");
        _goalChoice = int.Parse(Console.ReadLine());

    }
    public int GetOption()
    {
        return _option;
    }
    public int GetGoalChoice()
    {
        return _goalChoice;
    }

    public void DisplayGoals()
    {
        Console.Write("\n");
        foreach (Goal goal in _goalList)
        {
            goal.Display();
            Console.Write("\n");
        }
    }
    public void TotalScore()
    {
        foreach (Goal goal in _goalList)
        {
            _totalScore = 0;
            _totalScore += goal.GetScore();

        }
        Console.Write($"\nTotal Score: {_totalScore}");
    }

    public void Save()
    {

        Console.Write("Please input the filename you would like to save all of your goals to: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.FormatEntry());
            }
        }


    }
    public void Load()
    {
        Console.Write("Please input the filename you would like to load your goals from: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        //_journal._entryList.Clear();
        foreach (string line in lines)
        {
            string[] parts1 = line.Split(":");

            string goalType = parts1[0];
            string information = parts1[1];
            string[] parts2 = information.Split("|");
            if (goalType == "Checklist Goal")
            {

                string name = parts2[0];
                string goal = parts2[1];
                int points = int.Parse(parts2[2]);
                int bonus = int.Parse(parts2[3]);
                int outOf = int.Parse(parts2[4]);
                int completed = int.Parse(parts2[5]);
                int score = int.Parse(parts2[6]);

                Checklist newChecklist = new Checklist(name, goal, points, bonus, outOf, completed, score);
                _goalList.Add(newChecklist);

            }
            if (goalType == "Ongoing Goal")
            {
                string name = parts2[0];
                string goal = parts2[1];
                int points = int.Parse(parts2[2]);
                int score = int.Parse(parts2[3]);



                Ongoing newOngoing = new Ongoing(name, goal, points, score);
                _goalList.Add(newOngoing);

            }
            if (goalType == "Simple Goal")
            {
                string name = parts2[0];
                string goal = parts2[1];
                int points = int.Parse(parts2[2]);
                int score = int.Parse(parts2[3]);
                bool status = Convert.ToBoolean(parts2[4]);


                Simple newSimple = new Simple(name, goal, points, score, status);
                _goalList.Add(newSimple);

            }





        }
    }

    public void TrackGoal()
    {
        DisplayGoals();
        Console.Write("Input the goal number that you would like to record progress for: ");
        int _goalToRecord = int.Parse(Console.ReadLine());
        _goalList[_goalToRecord - 1].RecordEvent();


    }
    public void Level()
    {
        

        if (_totalScore < 100)
        {
            _level = "1";
            _pointsLeft = 100-_totalScore;


        }

        if (_totalScore >= 100)
        {
            _level = "2";
            _pointsLeft = 300-_totalScore;
        }
        if (_totalScore >= 300)
        {
            _level = "3";
            _pointsLeft = 900-_totalScore;
        }
        if (_totalScore >= 900)
        {
            _level = "4";
            _pointsLeft = 1500-_totalScore;
        }
        if (_totalScore >= 1500)
        {
            _level = "5";
            _pointsLeft = 2000-_totalScore;
        }
        if (_totalScore >= 2000)
        {
            _level = "Top-Notch";
            _pointsLeft = 0;
        }
        Console.Write($"\nLevel: {_level}\nYou have {_pointsLeft} points until you level up!");

    }

}
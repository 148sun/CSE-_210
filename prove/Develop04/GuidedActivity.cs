public class GuidedActivity : Activity
{
    //Attributes
    private string _yourExperience;
    private string _response;
    
    //Constuctor
    public GuidedActivity(string name) : base(name)
    {
        
        _description = "The activity will give you the opportunity to reflect on an experience of your choice. ";
        



    }

    //Method
    public void Guide()
    {
       Console.Write("Please input in the experience/event that you would like to reflect on: ");

       _yourExperience = Console.ReadLine();

       Console.WriteLine("We will now guide you through a series of questions related to your experience.");
        DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(_time);
        do
        {
            Console.Write($"What did you like about {_yourExperience}?");
            _response = Console.ReadLine();

            Console.Write($"What did you not like about {_yourExperience}?");
            _response = Console.ReadLine();

            Console.Write($"Who was involved during {_yourExperience}?");
            _response = Console.ReadLine();

            Console.Write($"Describe what happened during {_yourExperience}?");
            _response = Console.ReadLine();

            Console.Write($"Would you want to do {_yourExperience} again?");
            _response = Console.ReadLine();
            Console.Write($"What do you wish went different about {_yourExperience}?");
            _response = Console.ReadLine();
            Console.Write($"Was anything difficult or easy about {_yourExperience}?");
            _response = Console.ReadLine();
            Console.Write($"What was the best part about {_yourExperience} and why?");
            _response = Console.ReadLine();
            Console.Write($"Do you wish anyone else was there for {_yourExperience}?");
            _response = Console.ReadLine();



        }while (DateTime.Now < futureTime); 
    }
}
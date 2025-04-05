public class Memorize : Learn
{
    private Random rnd = new Random();
    //Constructor
    public Memorize(string topic) : base(topic)
    {
        _topic = topic;


    }
    




    //Methods
    public override void Practice(int frequency)
    {
        while (frequency > 0)
        {

            int index1 = rnd.Next(_conceptList.Count);
            Console.Write($"\nConcept: {_conceptList[1]}");
            string response = Console.ReadLine();
            response = " ";
            if (response == " ")
            {
                Console.Write($"\nExplanation: {_explanationList[index1]}");
                string waitResponse = Console.ReadLine();
            }
            frequency -= 1;
        }

    }

}
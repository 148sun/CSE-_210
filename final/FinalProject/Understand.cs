public class Understand : Learn
{
    //Attributes
    private Random rnd = new Random();

    private List<string> _promptList = new List<string>
    {"Create an example of",
    "Draw a picture related to",
    "Write a paragraph explaining",
    "Create a question related to",
    "List other terms that relate to",
    "Explain the importance of",
    "Explain a real world application of",
    "Research an interresting fact about",
    "Create a multiple choice problem about",
    "Create a venn diagram related to"};

    public Understand(string topic) : base(topic)
    {

    }
    




    //Methods
    public override void Practice(int frequency)
    {
        while (frequency > 0)
        {
            int index1 = rnd.Next(_promptList.Count);
            int index2 = rnd.Next(_conceptList.Count);
            Console.Write($"{_promptList[index1]} {_conceptList[index2]}");

            string response = Console.ReadLine();
            if (response == " ")
            {
                Console.Write($"Explanation: {_explanationList[index2]}");
            }
            frequency -= 1;
        }


    }
}

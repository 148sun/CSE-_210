public abstract class Memorize : Learn
{
    //Constructor
        public Memorize(string topic) : base(topic)
    {
        
    }
    public Random rnd = new Random();




    //Methods
    public override void Practice(int frequency)
    {
        while (frequency > 0)
        {
            
            int index1 = rnd.Next(_conceptList.Count);
            Console.Write($"Concept: {_conceptList[1]}");
            string response = Console.ReadLine();
            response = " ";
            if (response == " ")
            {
                Console.Write($"Explanation: {_explanationList[index1]}");
            }
            frequency -= 1;
        }

}
}
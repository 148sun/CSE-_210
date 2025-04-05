abstract public class Learn
{
    // Attributes
    protected string _topic;
    protected List<string> _conceptList = new List<string>();
    protected List<string> _explanationList = new List<string>();
    protected int _time;

    //Constructor
    public Learn(string topic)
    {
        _topic = topic;
    }

    //Methods
    public void Display()
    {
        for (int index = 0; index < _conceptList.Count; index++)
        {
            Console.Write($"{_conceptList[index]}:{_explanationList[index]}");
        }

    }
    

    public abstract void Practice(int frequency);

    public void GetMaterial()
    {
        Console.Clear();
        Console.Write("How many concepts would you like to study? "); int numberConcepts = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberConcepts; i++)
        {
            Console.Write("Concept: "); string concept = Console.ReadLine(); _conceptList.Add(concept);
            Console.Write("Description: "); string description = Console.ReadLine(); _explanationList.Add(description);

        }

    }



}
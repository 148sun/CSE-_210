public class Assignment
{
    protected string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //Method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}
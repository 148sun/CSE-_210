using System.Dynamic;

public class WritingAssignment : Assignment
{
    //Attributes
    string _title;
    
    
    //Constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //Method

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName} ";
    }
}
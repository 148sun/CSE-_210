public class Class : Event
{
    //Attributes
    private string _professorName;
    private string _professorContact;
    private string _professorOffice;
    private string _professorHours;

    //Constructor
    public Class(string name, string location, string start, string end, string professor) : base(name, location, start, end)
    {
        _professorName=professor;
        _professorContact = "---";
        _professorOffice = "---";
        _professorHours = "---";

    }

    //Methods
    public override string Display()
    {
        return $"{_start}-{_end}, {_name}, {_location}, {_professorName}";
    }

    public void GetProfessorInformation(string contact, string office, string hours)
    {
        _professorContact = contact;
        _professorHours = hours;
        _professorOffice = office;
    }

}
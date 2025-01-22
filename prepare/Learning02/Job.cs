

public class Job //Declaring the variable type as a class and saying this variable type has the name Job
{
   public string _company; //Declaring a
   public string _jobTitle;
   public int _startYear;
   public int _endYear;
   public void Display()
   {
      Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
   }
}



public class Job //Declaring the variable type as a class and saying this variable type has the name Job
{
   //Declaring the variable names/types
   public string _company;
   public string _jobTitle;
   public int _startYear;
   public int _endYear;
   
   //Declaring the function in our class
   public void Display()
   {
      Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
   }
}

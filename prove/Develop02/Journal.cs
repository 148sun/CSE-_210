
public class Journal //Declaring the variable type as a class and saying this variable type has the name Job
{
   //Declaring the variable names/types
   public List<Entry> _entryList = new List<Entry>();



   //Declaring the function in our class
   public void DisplayEntries()
   {
      foreach (Entry entry in _entryList)
      {
         entry.DisplayEntry();
      }
   }



}
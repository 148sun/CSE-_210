
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

   // public void CreateEntry()
   // {
   //    Entry entry1 = new Entry();
   //      entry1._dateTime = DateTime.Now.ToString("MM/dd/yyyy");
   //      entry1.DisplayPrompt();
   //      entry1.DisplayEntry();

   // }

}
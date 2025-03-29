public class Plan 
{
    //Attributes
    private List<Day> _listDays = new List<Day>();

    //Method
    public void Display()
    {
        foreach (Day day in _listDays)
        {
            day.DisplayDayPlan();
        }
    }

    public void SavePlan()
    {
        
    }




}
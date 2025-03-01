using System.Globalization;

public class BreatheActivity : Activity
{
    //constructor
    public BreatheActivity(string name): base(name)
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //Method
    public void Breathe() 
    {
        int intervals = _time/10;

       for (int j=intervals;j>0;j--)
       {
        Console.Write("\n\nBreath in...");
        for (int i=5; i>0; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");   
        }
        Console.Write("\nBreath out...");
        for (int i=5; i>0; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");   
        }
       } 
    }
}

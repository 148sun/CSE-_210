using System.Runtime.CompilerServices;

public class Menu
{
    public int _option;

    public void DisplayMenu()
    {
        Console.Write("Please select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWHat would you like to do? ");
        string _opt = Console.ReadLine();
        _option = int.Parse(_opt);
    }

    public void Save()
    {
        Console.Write("Please input the filename: ");
        //File.WriteAllLines("./file.txt", )
        
    }
    public void Loading()
    {

    }


}
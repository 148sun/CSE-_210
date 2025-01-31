using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Menu
{
    public int _option;
    public Journal _journal;

    public string _myMemory;

    public Random rnd = new Random();

    public void DisplayMenu()
    {
        Console.Write("Please select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Memory\n6. Clear Journal\n7. Quit\nWhat would you like to do? ");
        string _opt = Console.ReadLine();
        _option = int.Parse(_opt);
    }

    public void Save()
    {

        Console.Write("Please input the filename you would like to save your journal entries to: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _journal._entryList)
            {
                outputFile.WriteLine(entry.FormatEntryForSave());


            }
        }


    }
    public void Loading()
    {
        Console.Write("Please input the filename you would like to load as a new journal: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _journal._entryList.Clear();//something new
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string input = parts[2];
            Entry entry1 = new();
            entry1._dateTime = date;
            entry1._userInput = input;
            entry1._myPrompt = prompt;

            _journal._entryList.Add(entry1);


        }

    }
    public void Memory()
    {

        Console.Write("What file would you like to pull a random memory from? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _journal._entryList.Clear();//something new
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string input = parts[2];
            Entry entry1 = new();
            entry1._dateTime = date;
            entry1._userInput = input;
            entry1._myPrompt = prompt;

            _journal._entryList.Add(entry1);
        }
        int integer = rnd.Next(_journal._entryList.Count);
        Entry _myMemory = _journal._entryList.ElementAt(integer);
        _journal._entryList.Clear();
        _journal._entryList.Add(_myMemory);
        _journal.DisplayEntries();
        _journal._entryList.Clear();

    }
    public void Clear()
    {
        _journal._entryList.Clear();
    }
}
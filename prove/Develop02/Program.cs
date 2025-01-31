using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Quic;


class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        Journal journal1 = new Journal();
        menu1._journal = journal1;

        do
        {
            menu1.DisplayMenu();
            Console.WriteLine();

            if (menu1._option == 1)
            {

                Entry entry1 = new Entry();
                entry1._dateTime = DateTime.Now.ToString("MM/dd/yyyy");
                entry1.DisplayPrompt();

                journal1._entryList.Add(entry1);

            }
            if (menu1._option == 2)
            {
                // Console.Write("Would you like to display your unsaved journal(1) or your loaded journal(2)? ");
                // string display = Console.ReadLine();
                // int _display = int.Parse(display);
                
                // if (_display == 1)
                // {
                    journal1.DisplayEntries();
                // }
                // if (_display == 2)
                // {
                //     journal
                // }

                
            }
            if (menu1._option == 3)
            {
                menu1.Loading();
            }
            if (menu1._option == 4)
            {
                menu1.Save();
            }
            if (menu1._option == 5)
            {
                menu1.Memory();
            }
            if (menu1._option == 6)
            {
                menu1.Clear();
            }

        } while (menu1._option != 7);
    }
}
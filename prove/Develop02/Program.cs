using System;
using System.Net.Quic;


class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        // Entry entry1 = new Entry();
        // entry1._allPrompts.Add("How do you feel about this assignment?");
        // entry1._allPrompts.Add("Do you beleive that you can complete this assignment? ");
        // entry1._dateTime = "01/28/2025";
        // entry1.DisplayPrompt();
        // entry1.DisplayEntry();
        
        
        do
        {
            menu1.DisplayMenu();
            //trying soemthign out
            // string _opt = Console.ReadLine();
            // int opt = int.Parse(_opt);

        Journal journal1 = new Journal();
        // if (opt== 1)
        if (menu1._option == 1)
        {
            
            Entry entry1 = new Entry();
            entry1.DisplayPrompt();
            
            journal1._entryList.Add(entry1);
            journal1.DisplayEntries();
            Console.Write(journal1._entryList);
        }
        else if (menu1._option == 2)
        {
            journal1.DisplayEntries();
        }
        if (menu1._option == 3)
        {
            menu1.Loading();
        }
        if (menu1._option == 4)
        {
            menu1.Save();
        }

        } while(menu1._option != 5);
            }
}
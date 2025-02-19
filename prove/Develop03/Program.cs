using System;
using System.ComponentModel;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

    Console.Write("Welcome to the Scripture Memorizer!\nWould you like to memorize 3 Nephi 20:42 (1) or your own scripture (2)? ");
    int _option = int.Parse(Console.ReadLine());
    
    if (_option == 1)
    {
        Console.Clear();
        Scripture scripture = new Scripture();
        string _next;
      
        do
        {
            scripture.SendScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            _next = Console.ReadLine();
            if (_next != "quit")
            {
                _next = "";
            }
    
            scripture.RandomDisappear();   
            
            Console.Clear();
        } while (_next == "" && scripture.ScriptureStatus() == true);
        Console.Clear();
        

        
    }
    if (_option == 2)
    {
        int _verse1 = 1;
        int _verse2 = 1;
        
        Console.WriteLine("What is the book of your scripture? ");
        string _book = Console.ReadLine();
        Console.WriteLine("What is the chapter of your scripture? ");
        int _chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Does your scripture have 1 or 2 verses? ");
        int _verses = int.Parse(Console.ReadLine());
        if (_verses == 1)
        {
            Console.WriteLine("What verse? ");
            _verse1 = int.Parse(Console.ReadLine());
            _verse2 = _verse1;
        }
        if (_verses == 2)
        {
            Console.WriteLine("What is the first verse? ");
            _verse1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the second verse? ");
            _verse2 = int.Parse(Console.ReadLine());    
        }
        Reference _reference = new Reference(_book, _chapter, _verse1, _verse2);
        
        Console.WriteLine("Input the scripture please: ");
        string _scripture = Console.ReadLine();
        
        Console.Clear();
        Scripture scripture = new Scripture(_reference, _scripture);
        string _next;
      
        do
        {
            scripture.SendScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            _next = Console.ReadLine();
            if (_next != "quit")
            {
                _next = "";
            }
    
            scripture.RandomDisappear();   
            
            Console.Clear();
        } while (_next == "" && scripture.ScriptureStatus() == true);
        Console.Clear();
        

    
        
    }



    }
}
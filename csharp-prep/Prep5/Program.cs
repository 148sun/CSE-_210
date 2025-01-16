using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }


        static string PromptUserName()
        {
            Console.Write("Please Enter your name: ");
            string yourName = Console.ReadLine();
            return yourName;

        }
        static int PromptUserNumber()
        {
            Console.Write("Please Enter your favorite integer: ");
            string yourNumber = Console.ReadLine();
            return int.Parse(yourNumber);
        }
        static int SquareNumber(int integer)
        {
            return integer * integer;
        }
        static void DisplayResult(string Name, int squared)
        {
            Console.WriteLine($"{Name}, the square of your number is {squared}");
        }
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squared = SquareNumber(number);
            DisplayResult(name,squared);
        }
        Main();
        

}
}
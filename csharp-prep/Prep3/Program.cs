using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
       int theNumber = randomGenerator.Next(1,100);
       
    
       int yourGuess = theNumber + 2;
       

       while (yourGuess != theNumber)
       {
        Console.Write("Please input a guess: ");
        string guess = Console.ReadLine();
        yourGuess = int.Parse(guess);

       if (yourGuess < theNumber)
       {
        Console.WriteLine("Higher");
       }
       else if (yourGuess > theNumber)
       {
        Console.WriteLine("Lower");
       }
       else if (yourGuess == theNumber)
       {
        Console.WriteLine("Nice work, you guessed it!");
       }
       } 
    }
}

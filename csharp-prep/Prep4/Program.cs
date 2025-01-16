using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int yourNumber = 2;
        
        List<int> numbersAll = new List<int>();
        while (yourNumber != 0)
        {
            Console.Write("Enter number: ");
            yourNumber = int.Parse(Console.ReadLine());
            
            if (yourNumber != 0)
            {
                numbersAll.Add(yourNumber);
            }
            

        } 
        
        int sum = numbersAll.Sum();
        double average = (double)sum / (numbersAll.Count);
        int max = numbersAll.Max();
        Console.Write($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {max}");
        


    }
}
using System;

class Program
{
    
    static void Main(string[] args)
    {
        int _seconds = 5;
              DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);

        Console.WriteLine("Get ready...");

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("\b\b");
            Console.Write("/");
            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("|");
            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");
            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("-");
            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("/");
            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("|");
            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");

            currentTime = DateTime.Now;
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("-");

            Thread.Sleep(500);

            currentTime = DateTime.Now;
        }
    
// DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(10);

// //Thread.Sleep(3000);

// DateTime currentTime = DateTime.Now;
// while (currentTime < futureTime)
// {
//     Console.Write("\b\b");
//     Console.Write("/");

//     Thread.Sleep(500);
//     Console.Write("\b\b");
//     Console.Write("|");
    
//     Thread.Sleep(500);
//     Console.Write("\b\b"); 
//     Console.Write("\\");

//     Thread.Sleep(500);
//     Console.Write("\b\b");
//     Console.Write("-");

//     Thread.Sleep(500);
//     Console.Write("\b\b");
//     Console.Write("/");

//     Thread.Sleep(500);
//     Console.Write("\b\b");
//      Console.Write("|"); 

//     Thread.Sleep(500);
//     Console.Write("\b\b"); 
//     Console.Write("\\");

//     Thread.Sleep(500);
//     Console.Write("\b\b");
//     Console.Write("-");
    
//     Thread.Sleep(500);

//     currentTime = DateTime.Now;
//}
    
    //     Console.Write("Breath in...");
    //     for (int i=5; i>0; i--)
    //    {
    //     Console.Write(i);
    //     Thread.Sleep(1000);
    //     Console.Write("\b \b");
        

        //Console.Clear();
       //}
   
    }
}
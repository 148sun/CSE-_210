using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Amanda Barlow", "Bayesian");
        // Console.WriteLine(assignment.GetSummary());


        // MathAssignment massignment = new MathAssignment("Amanda Barlow", "PDE", "4.3", "3-4");
        // Console.WriteLine(massignment.GetSummary());
        // Console.WriteLine(massignment.GetHomeworkList());

        WritingAssignment wassignment = new WritingAssignment("Amanda", "math", "The Wonderful adventures of PDE");
        Console.WriteLine(wassignment.GetSummary());
        Console.WriteLine(wassignment.GetWritingInformation());

    }
}
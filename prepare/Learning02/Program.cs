using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //Create a new instance/object of the class Job

        //Assign the variables in the object job1, we don't need to declare the variable type because we already have that in the class
        job1._jobTitle = "Software Engineer"; 
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Call the function in the object job1
        job1.Display();

        //Create a new instance/object of the class Job named job2
        Job job2 = new Job();

        //Assign variables in the object job2, we don't need to declare the variable type because we already have that declared in the class
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Call the function in the object job2
        job2.Display();

        Resume resume1 = new Resume();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1._name = "Francis Barlow";

        

        resume1.Display();

    }

}
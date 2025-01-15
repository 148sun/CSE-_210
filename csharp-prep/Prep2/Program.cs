using System;

Console.Write("What is your grade percentage? ");
string yourGrade = Console.ReadLine();
int gradePercentage = int.Parse(yourGrade);
string Letter = "hi";
if (gradePercentage >= 90)
{
    Letter = "A";
}
else if (gradePercentage >= 80)
{
    Letter = "B";
}
else if (gradePercentage >= 70)
{
    Letter = "C";
}
else if (gradePercentage >= 60)
{
        Letter = "D";


}
else
{
        Letter = "D";

}
if (gradePercentage >= 70)
{
    Console.WriteLine($"\nCongratulations, you passed the class with the grade {Letter}!! ");
}
else
{
    Console.WriteLine($"\nYou sadly did not pass the class. Your grade was {Letter}. I recommend trying again. ");
}
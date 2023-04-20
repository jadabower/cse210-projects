using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        Console.Write("What percent grade do you have in the course? ");
        string userInputPercentGrade = Console.ReadLine();
        int percentGrade =  int.Parse(userInputPercentGrade);

        if (percentGrade >= 90)
        {
            letterGrade = "A";
            if (((percentGrade % 10) <= 3) && (percentGrade < 100))
            {
                letterGrade += "-";
            }
        }
        else if ((percentGrade >= 80) && (percentGrade < 90))
        {
            letterGrade = "B";
            if ((percentGrade % 10) >= 7)
            { 
                letterGrade += "+";
            }
            else if ((percentGrade % 10) <= 3)
            {
                letterGrade += "-";
            }        
        }
        else if ((percentGrade >= 70) && (percentGrade < 80))
        {
            letterGrade = "C";
            if ((percentGrade % 10) >= 7)
            { 
                letterGrade += "+";
            }
            else if ((percentGrade % 10) <= 3)
            {
                letterGrade += "-";
            }
        }
        else if ((percentGrade >= 60) & (percentGrade < 70))
        {
            letterGrade = "D";
            if ((percentGrade % 10) >= 7)
            { 
                letterGrade += "+";
            }
            else if ((percentGrade % 10) <= 3)
            {
                letterGrade += "-";
            }
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (percentGrade >= 70)
        {
            Console.WriteLine("You passed the course! Congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but you can do it next time!");
        }
    }
}
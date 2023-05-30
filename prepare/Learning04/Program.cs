using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mAssignment = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(mAssignment.GetSummary());
        Console.WriteLine(mAssignment.GetHomeworkList());
        WritingAssignment wAssignment = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(wAssignment.GetSummary());
        Console.WriteLine(wAssignment.GetWritingInformation());
    }
}
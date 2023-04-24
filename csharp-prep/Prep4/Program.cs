using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int numToAdd = 1;
        int biggestNum = -999999;
        int sum = 0;
        List<int> numbers = new List<int>();

        while (numToAdd != 0)
        {
            Console.Write("Enter number: ");
            string numAsStr = Console.ReadLine();
            numToAdd = int.Parse(numAsStr);

            if (numToAdd != 0)
            {
                numbers.Add(numToAdd);
            }
        }

        foreach (int num in numbers)
        {
            sum += num;
            if (num > biggestNum)
            {
                biggestNum = num;
            }
        }

        double dSum = sum;
        double average = (dSum / (numbers.Count));

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
    }
}
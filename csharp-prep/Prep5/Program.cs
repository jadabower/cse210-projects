using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumStr = Console.ReadLine();
        int userNum = int.Parse(userNumStr);

        return userNum;
    }

    static int SquareNumber(int numToSquare)
    {
        int numSquared = (numToSquare * numToSquare);

        return numSquared;
    }

    static void DisplayResult(string userName, int numSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numSquared}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared);
    }
}
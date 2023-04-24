using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(0, 101);

        int guessNum;

        do
        {
            Console.Write("What is your guess? ");
            string guessAsString = Console.ReadLine();
            guessNum = int.Parse(guessAsString);

            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while(guessNum != magicNum);
    }
}
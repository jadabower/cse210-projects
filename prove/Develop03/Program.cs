using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        //console cleared
        //display original scripture
        Console.WriteLine($"\nPress enter to continue or type 'quit' to finish:");
        string choice = Console.ReadLine();
        
        while(choice != "quit")
        {
            Console.Clear();
            if (scripture.IsWholeVerseBlank())
            {
                break;
            }
            scripture.BlankNextRandomWords();
            Console.WriteLine(scripture.GetScriptureWithBlanks());
            Console.WriteLine($"\nPress enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            //generate random blanks
            //console cleared
            //write scripture with blanks
            //ask for user input
            
        }
    }
}
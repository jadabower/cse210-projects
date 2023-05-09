public class Menu
{
    public Menu()
    {
    }

    public void LoadJournal()
    {
        // asks the user for the filename of the journal they want to open then presents the journal menu
        Console.WriteLine("What is the file name of the journal you would like to open?");
        string filename = Console.ReadLine() ?? String.Empty;
        Journal journal = new Journal(filename);
        JournalMenu(journal);
    }

    public void JournalMenu(Journal journal)
    {
        // goes through the menu options and does the specified tasks until they quit
        string choice = "";
        while (choice.ToUpper() != "D")
        {
            Console.WriteLine("Select one of the following:");
            Console.WriteLine("'A' Create a new entry");
            Console.WriteLine("'B' Display the journal");
            Console.WriteLine("'C' Save the journal");
            Console.WriteLine("'D' Quit");
            choice = Console.ReadLine() ?? String.Empty;
            Console.WriteLine();
            if (choice.ToUpper() == "A")
            {
                // creates a new entry in the journal
                journal.NewEntry();
            }
            else if (choice.ToUpper() == "B")
            {
                // displays the journal
                journal.DisplayJournal();
            }
            else if (choice.ToUpper() == "C")
            {
                // saves the journal to the file
                journal.SaveJournal();
            }
            else
            {
                // quits
                break;
            }
        }
    }
}
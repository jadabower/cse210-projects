public class Menu
{
    public Menu()
    {
        Console.WriteLine("Welcome to your very own Goal planner!");
        Console.Write("What is the name of the text file with your goals (ex: myGoals.txt)? ");
        string filename = Console.ReadLine();
        GoalsList goalsList = new GoalsList(filename);

        while (true)
        {
            Console.WriteLine("Select one of the following:");
            Console.WriteLine("'A' Create a new goal");
            Console.WriteLine("'B' Record event");
            Console.WriteLine("'C' Display goals");
            Console.WriteLine("'D' Save goals");
            Console.WriteLine("'E' Quit");
            string choice = Console.ReadLine() ?? String.Empty;
            Console.WriteLine();
            if (choice.ToUpper() == "A")
            {
                goalsList.AddGoal();
            }
            else if (choice.ToUpper() == "B")
            {
                goalsList.RecordEvent();
            }
            else if (choice.ToUpper() == "C")
            {
                goalsList.SaveToFile();
                goalsList.DisplayList();
            }
            else if (choice.ToUpper() == "D")
            {
                goalsList.SaveToFile();
            }
            else
            {
                break;
            }
        }
    }
}
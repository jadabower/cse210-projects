public class Menu
{
    public void DisplayMenu()
    {

        string choice = "";
        while (choice.ToUpper() != "4")
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity.");
            Console.WriteLine("  2. Start reflecting activity.");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine() ?? String.Empty;
            Console.Clear();
            if (choice == "1")
            {
                Breathe breathe = new Breathe("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathe.DisplayBreatheActivity();
            }
            else if (choice.ToUpper() == "2")
            {
                Reflect reflect = new Reflect("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.DisplayReflectActivity();
            }
            else if (choice.ToUpper() == "3")
            {
                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.DisplayListingActivity();
            }
            else
            {
                break;
            }
        }
    }
}
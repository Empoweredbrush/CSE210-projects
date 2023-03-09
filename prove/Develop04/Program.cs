using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What is your name?");
       string userName = Console.ReadLine();

       Console.Clear();
       Console.WriteLine("How long would you like to spend in this program? (please put number in seconds)");
       int seconds = int.Parse(Console.ReadLine());

       Console.Clear();
       ActivityMenu activity1 = new ActivityMenu(userName, seconds);
       activity1.Menu();

       int choice = int.Parse(Console.ReadLine());
       Console.Clear();
       switch (choice)
       {
        case 1:
            Breathing breathing1 = new Breathing(userName, seconds);
            breathing1.BreathingActivity();
            break;
        case 2:
            Reflection reflection1 = new Reflection(userName, seconds);
            reflection1.ReflectionActivity();
            break;
        case 3:
            Listing listing1 = new Listing(userName, seconds);
            listing1.ListingActivity();
            break;
        default:
            Console.WriteLine("Please enter a valid option.");
            break;
       }
    }
}
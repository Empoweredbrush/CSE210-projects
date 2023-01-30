using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        Journal journal1 = new Journal();

        Console.WriteLine("Welcome to your Journal Program!");
        Console.WriteLine("Please choose from the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. View journal");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1)
        {
            Console.WriteLine("Would you like to save your entry?(Type 1 for yes, type 0 for no.)");
            int saveUserChoice = int.Parse(Console.ReadLine());
            if (saveUserChoice == 1){
                entry1._prompts.Add("What brought a smile today?");
                entry1._prompts.Add("What important event occured?");
                entry1._prompts.Add("Anything funny happen today?");

                entry1.DisplayPrompt();

                journal1._userEntries.Add(entry1._userResponse);
                
                
                journal1.SaveJournal(journal1._userEntries[0]);
                


            }
            else if (saveUserChoice != 1)
            {
                entry1._prompts.Add("What brought a smile today?");
                entry1._prompts.Add("What important event occured?");
                entry1._prompts.Add("Anything funny happen today?");

                entry1.DisplayPrompt();
            }
            else {
                Console.WriteLine("Please type 1 or 0 for your choice.");
            }
        }
        else if (userChoice == 2)
        {
            journal1.LoadJournal();
        }
        else{
            Console.WriteLine("Please enter 1 or 2 from the options.");
        }
    }
}
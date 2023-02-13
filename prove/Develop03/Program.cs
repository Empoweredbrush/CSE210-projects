using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureStorage storage1 = new ScriptureStorage();
        Memorization memoryGame = new Memorization();
        ReferenceGame reference = new ReferenceGame();

        Console.WriteLine("Welcome to the Scripture Storage Program!!!!\n Please choose an option:\n1. Save a scripture to the library\n2. load the current scripture library\n3. test your memorization\n(please use the numbers associated with the options to answer.)");
        int userResponse = int.Parse(Console.ReadLine());

        if (userResponse == 1)
        {
            Console.Clear();
            storage1.DictionaryCreator();
            storage1.StorageSave();
        }
        else if (userResponse == 2)
        {
            Console.Clear();
            storage1.StorageLoad();
        }
        else if (userResponse == 3)
        {
            Console.WriteLine("Would you like to memorize a scripture or practice matching the reference with the scripture?\n(Please type 1 for memorizing a scripture and 2 for matching a reference with a scripture.)");
            int response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                Console.Clear();
                memoryGame.MemoryGame();
            }
            else if (response == 2)
            {
                Console.Clear();
                reference.ReferenceTest();
            }
        }
        
    }
}
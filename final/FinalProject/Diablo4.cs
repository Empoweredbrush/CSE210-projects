public class Diablo4 : Character
{
    public void CharacterCreator()
    {
        Console.WriteLine("Hello and welcome to Diablo 4, this will be the newest installment of the series but be aware that since it is not officially out yet, some of the info given here may change.");
        Console.WriteLine("The classes given are:");
        Console.WriteLine("1. Barbarian\n2. Rogue\n3. Scorcerer\n4. Help");
        Console.WriteLine("Please choose the number associated with the class.");

        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice)
        {
            case 1:
                SetStrength(10);
                SetDexterity(8);
                SetIntelligence(7);
                SetWillpower(7);
                Barbarian();
                break;
            case 2:
                SetStrength(7);
                SetDexterity(10);
                SetIntelligence(7);
                SetWillpower(8);
                Rogue();
                break;
            case 3:
                SetStrength(7);
                SetDexterity(7);
                SetIntelligence(10);
                SetWillpower(8);
                Scorceress();
                break;
        }

        Console.WriteLine("Would you like to save your character? yes or no");

        string answer = Console.ReadLine();

        switch(answer.ToLower())
        {
            case "yes":
                CharacterJournal journal = new CharacterJournal();
                Console.WriteLine("What will you name your character?");
                string name = Console.ReadLine();

                Console.WriteLine("WHat was the class of your character?");
                string characterClass = Console.ReadLine();
                string gameName = "Diablo 4";
                journal.CharacterSave(name, characterClass, gameName);
                break;
            default:
                break;
        }
    }

    public override void Barbarian()
    {
        Console.WriteLine($"The Barbarian, a powerful melee combatant. Yourn starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nIntelligence: {GetIntelligence()}\nWillpower: {GetWillpower()}");
    }

    public void Rogue()
    {
        Console.WriteLine($"The Rogue, a shadow and powerful user of trickery and traps. Yourn starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nIntelligence: {GetIntelligence()}\nWillpower: {GetWillpower()}");
    }

    public override void Scorceress()
    {
        Console.WriteLine($"The Scorcerer, master of the mystic arts. Yourn starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nIntelligence: {GetIntelligence()}\nWillpower: {GetWillpower()}");
    }

    public void Help()
    {

    }
}
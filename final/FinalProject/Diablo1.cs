public class Diablo1 : Character
{
    private int _magic;

    public void CharacterCreate()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Diablo 1, the first game of the series.\nBelow are the list of classes to choose from along with a simple description.\nPlease choose your class");
        Console.WriteLine("1. Warrior: A melee fighter benefiting from large amounts of strength.");
        Console.WriteLine("2. Rogue: A master of the bow and given the innate power of the sixth sense");
        Console.WriteLine("3. Bard: Jack of all trades");
        Console.WriteLine("4. Monk: Master of hand to hand combat");
        Console.WriteLine("5. Scorceror: Master of the magic arts");

        Console.WriteLine("Please enter the number associated with the class you wish to create.");
        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice)
        {
            case 1:
                Console.Clear();
                Warrior();
                break;
            case 2:
                Console.Clear();
                Rogue();
                break;
            case 3:
                Console.Clear();
                Bard();
                break;
            case 4:
                Console.Clear();
                Monk();
                break;
            case 5:
                Console.Clear();
                Scorceress();
                break;
            default:
                Console.WriteLine("Please enter a number associated with the classes.");
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
                string gameName = "Diablo 1";
                journal.CharacterSave(name, characterClass, gameName, GetMagic());
                break;
            default:
                break;
        }
    }

    public int GetMagic()
    {
        return _magic;
    }

    public void Warrior()
    {   
        SetStrength(30);
        _magic = 10;
        SetDexterity(20);
        SetVitality(25);
        SetStartingLife(70);

        Console.WriteLine($"The warrior bolsters great strength, allowing for the use of a variety of weapons.\nThe starting stats for your character is:\nStrength: {GetStrength()}\nMagic: {_magic}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nStarting LifePoints: {GetStartingLife()}\n");
    }

    public void Rogue()
    {
        SetStrength(20);
        _magic = 15;
        SetDexterity(30);
        SetVitality(20);
        SetStartingLife(45);

        Console.WriteLine($"The Rogue, a fast and deadly fighter, utlizing bows and ranged attacks to destroy her foes. The starting stats for your character is:\nStrength: {GetStrength()}\nMagic: {_magic}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nStarting Lifepoints: {GetStartingLife()}");
    }

    public void Bard()
    {
        SetStrength(20);
        _magic = 20;
        SetDexterity(25);
        SetVitality(20);
        SetStartingLife(45);

        Console.WriteLine($"The Bard, a jack of all trades with the ability to dual wield weapons.\nYour starting stats are:\nStrength: {GetStrength()}\nMagic: {_magic}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nStarting Lifepoints: {GetStartingLife()}");
    }

    public override void Scorceress()
    {
        SetStrength(15);
        _magic = 35;
        SetDexterity(15);
        SetVitality(20);
        SetStartingLife(30);

        Console.WriteLine($"The scorceress, master of the magical arts.\nThe stats for this class are:\nStrength: {GetStrength()}\nMagic: {_magic}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nStarting LifePoints: {GetStartingLife()}");
    }

    public override void Monk()
    {
        SetStrength(25);
        _magic = 15;
        SetDexterity(25);
        SetVitality(20);
        SetStartingLife(45);

        Console.WriteLine($"The Monk, master of hand to hand combat.\nThe stats for this class is:\nStrength: {GetStrength()}\nMagic: {_magic}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nStarting LifePoints: {GetStartingLife()}");
    }
}
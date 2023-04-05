public class Diablo2 : Character
{
    private int _energy;

    public void CharacterCreate()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Diablo 2, the second game in the series. Below are the various classes that can be found within the game.");
        Console.WriteLine("When you are ready, please choose the class you wish to build.");
        Console.WriteLine("1. Amazon: A very versatile fighter, skilled in the bow and spear");
        Console.WriteLine("2. Assassin: Schooled in martail arts, both their mind and body are deadly weapons");
        Console.WriteLine("3. Barbarian: Unequaled in combat and master of all weapons");
        Console.WriteLine("4. Druid: Commanding the forces of nature, calling both wild beast and storms to their side.");
        Console.WriteLine("5. Necromancer: Summoner of undead minions and curses their enemies");
        Console.WriteLine("6. Paladin: Natural party leader, Holy man, and Blessed Warrior");
        Console.WriteLine("7. Scorceress: Master of elemental magics--Fire, Ice, Lightning");

        Console.WriteLine("Please type the number associated with the class.");
        int answer = int.Parse(Console.ReadLine());

        switch (answer)
        {
            case 1:
                Amazon();
                break;
            case 2:
                Assassin();
                break;
            case 3:
                Barbarian();
                break;
            case 4:
                Druid();
                break;
            case 5:
                Necromancer();
                break;
            case 6:
                Paladin();
                break;
            case 7:
                Scorceress();
                break;
        }

        Console.WriteLine("Would you like to save your character? yes or no");

        string userChoice = Console.ReadLine();

        switch(userChoice.ToLower())
        {
            case "yes":
                CharacterJournal journal = new CharacterJournal();
                Console.WriteLine("What will you name your character?");
                string name = Console.ReadLine();

                Console.WriteLine("WHat was the class of your character?");
                string characterClass = Console.ReadLine();
                string gameName = "Diablo 2";
                journal.CharacterSave(name, characterClass, gameName, GetEnergy());
                break;
            
            default:
                break;
        }
    }

    public int GetEnergy()
    {
        return _energy;
    }

    public void Amazon()
    {
        Console.Clear();
        SetStrength(20);
        SetDexterity(25);
        SetVitality(20);
        _energy = 15;
        SetStartingLife(50);

        Console.WriteLine($"The Amazon is a skilled warrior in bows and spears, their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nLife: {GetStartingLife()}");
    }

    public void Assassin()
    {
        SetStrength(20);
        SetDexterity(20);
        SetVitality(20);
        _energy = 25;
        SetStartingLife(50);

       Console.WriteLine($"The Assassin, having been trained to have their body be a weapon. Their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nStarting LifePoints: {GetStartingLife()}");
    }

    public override void Barbarian()
    {
        SetStrength(20);
        SetDexterity(25);
        SetVitality(20);
        _energy = 15;
        SetStartingLife(50);

        Console.WriteLine($"The Barbarian, a impressively strong warrior, master of all weapons.. Their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nStarting LifePoints: {GetStartingLife()}");
    }

    public void Druid()
    {
        SetStrength(15);
        SetDexterity(20);
        SetVitality(25);
        _energy = 20;
        SetStartingLife(55);

        Console.WriteLine($"The Druid, controller of nature and able to change into whatever animal needed. Their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nStarting LifePoints: {GetStartingLife()}");
    }

    public override void Necromancer()
    {
        SetStrength(15);
        SetDexterity(25);
        SetVitality(15);
        _energy = 25;
        SetStartingLife(45);

        Console.WriteLine($"The Necromancer, commander of the undead. Their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nStarting LifePoints: {GetStartingLife()}");
    }

    public void Paladin()
    {
        SetStrength(25);
        SetDexterity(20);
        SetVitality(25);
        _energy = 15;
        SetStartingLife(55);

        Console.WriteLine($"The Paladin, a holy warrior, the natural party leader. Their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nStarting LifePoints: {GetStartingLife()}");
    }

    public override void Scorceress()
    {
        SetStrength(10);
        SetDexterity(25);
        SetVitality(10);
        _energy = 35;
        SetStartingLife(40);

        Console.WriteLine($"The Scorceress, master of the mystic arts. Their starting stats are:\nStrength: {GetStrength()}\nDexterity: {GetDexterity()}\nVitality: {GetVitality()}\nEnergy: {_energy}\nStarting LifePoints: {GetStartingLife()}");
    }
}
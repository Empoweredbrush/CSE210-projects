public class Diablo3 : Character
{
    public void CharacterCreate()
    {
        Console.WriteLine("Welcome to Diablo 3, here you will have a good size of characters to play.");
        Console.WriteLine("Please choose your class from the list: ");
        Console.WriteLine("1. Barbarian");
        Console.WriteLine("2. Crusader");
        Console.WriteLine("3. Demon Hunter");
        Console.WriteLine("4. Monk");
        Console.WriteLine("5. Necromancer");
        Console.WriteLine("6. Wizard");
        Console.WriteLine("7. Witch Doctor");

        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice)
        {
            case 1:
                SetStrength(10);
                SetIntelligence(8);
                SetVitality(9);
                SetDexterity(8);
                Barbarian();
                break;
            case 2:
                SetStrength(10);
                SetIntelligence(8);
                SetVitality(9);
                SetDexterity(8);
                Crusader();
                break;
            case 3:
                SetStrength(8);
                SetIntelligence(8);
                SetVitality(9);
                SetDexterity(10);
                DemonHunter();
                break;
            case 4:
                SetStrength(8);
                SetIntelligence(8);
                SetVitality(9);
                SetDexterity(10);
                Monk();
                break;
            case 5:
                SetStrength(8);
                SetIntelligence(10);
                SetVitality(9);
                SetDexterity(8);
                Necromancer();
                break;
            case 6:
                SetStrength(8);
                SetIntelligence(10);
                SetVitality(9);
                SetDexterity(8);
                Wizard();
                break;
            case 7:
                SetStrength(8);
                SetIntelligence(10);
                SetVitality(9);
                SetDexterity(8);
                WitchDoctor();
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
                string gameName = "Diablo 3";
                journal.CharacterSave(name, characterClass, gameName);
                break;
            default:
                break;
        }
    }

    public void Help()
    {

    }

    public override void Barbarian()
    {
        Console.WriteLine($"The barbarian is a powerful warrior, focusing on strength to destroy his enemies. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }

    public override void Crusader()
    {
        Console.WriteLine($"The Crusader is a holy warrior, using powerful abilities to protect himself and others. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }

    public override void DemonHunter()
    {
        Console.WriteLine($"The Demon Hunter, a powerful ranged combatant, using traps and turrets to vanguish those before him. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }

    public override void Monk()
    {
        Console.WriteLine($"The Monk, master of hand to hand combat and utilizing Chakras to aid his fellow companions. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }

    public override void Necromancer()
    {
        Console.WriteLine($"The Necromancer, master of the undead magical arts, summoning armies of skeletons to aid his cause. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }

    public override void Wizard()
    {
        Console.WriteLine($"The Wizard, a rogue magic user searching for ancient magical secrets. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }

    public void WitchDoctor()
    {
        Console.WriteLine($"The Witch Doctor, master of Voodoo and using curses to fell his enemies. Your stats are:\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nVitality: {GetVitality()}\nDexterity: {GetDexterity()}");
    }
}
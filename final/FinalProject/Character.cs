public class Character
{
    //Strength is used in all Diablo games.
    private int _strength;
    //Dexterity is ued in Diablo 1, 2, and 3.
    private int _dexterity;
    //Vitality is used in all Diablo games
    private int _vitality;
    //Intelligence is used in Diablo 3 and Immortal
    private int _intelligence;
    //Willpower is used in Diablo Immortal and 4(Note: Diablo 4 items are in work in progress as full game has not been released. This will be here to eventually be used when the full game is out.)
    private int _willpower;
    private int _startingLife;

    public int GetStartingLife()
    {
        return _startingLife;
    }

    public void SetStartingLife(int value)
    {
        _startingLife = value;
    }

    public int GetStrength()
    {
        return _strength;
    }

    public void SetStrength(int value)
    {
        _strength = value;
    }

    public int GetDexterity()
    {
        return _dexterity;
    }

    public void SetDexterity(int value)
    {
        _dexterity = value;
    }

    public int GetVitality()
    {
        return _vitality;
    }

    public void SetVitality(int value)
    {
        _vitality = value;
    }

    public int GetIntelligence()
    {
        return _intelligence;
    }

    public void SetIntelligence(int value)
    {
        _intelligence = value;
    }

    public int GetWillpower()
    {
        return _willpower;
    }

    public void SetWillpower(int value)
    {
        _willpower = value;
    }

    //Classes used amongst several games: these classes will have the associated stats that are used in their respective game along with a level.
    //Barbarian is used in Diablo 2, 3, and Immortal
    public virtual void Barbarian()
    {
        //This method creates the character using the Barbarian class
    }

    public virtual void Crusader()
    {
        
    }

    //Monk is used in Diablo 1, 3, and Immortal
    public virtual void Monk()
    {
        //This method creates the Monk class for the character
    }

    //Demon Hunter is used in Diablo 3 and Immortal
    public virtual void DemonHunter()
    {
        //Creates the Demon Hunter class for the character
    }

    //Necromancer is used in Diablo 2, 3, and Immortal
    public virtual void Necromancer()
    {
        //Creates the Necromancer class for the character
    }

    //The scorceress, or scorcerer for some games, is found in Diablo 1, and 2
    public virtual void Scorceress()
    {
        //Creates the Scorceress class for the character
    }

    //Wizards are used in Diablo 3, and Immortal
    public virtual void Wizard()
    {
        //Creates Wizard class for character
    }
}
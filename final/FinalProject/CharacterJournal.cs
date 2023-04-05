using System.IO;
public class CharacterJournal : Character
{
    private List<int> _stats = new List<int>();
    private string _name;
    private string fileName = "My Characters";

    public void CharacterSave(string name, string character, string gameName, int magic = 0, int energy = 0)
    {
        _name = name;

        switch(gameName.ToLower())
        {
            case "diablo 1":
                _stats.Add(GetStrength());
                _stats.Add(GetDexterity());
                _stats.Add(GetVitality());
                _stats.Add(magic);
                _stats.Add(GetStartingLife());

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(_name);
                    outputFile.WriteLine($"Class: {character}");
                    outputFile.WriteLine($"Strength: {_stats[0]}");
                    outputFile.WriteLine($"Dexterity: {_stats[1]}");
                    outputFile.WriteLine($"Vitality: {_stats[2]}");
                    outputFile.WriteLine($"Magic: {magic}");
                    outputFile.WriteLine($"Starting LifePoints: {_stats[3]}");
                }
                break;
            case "diablo 2":
                _stats.Add(GetStrength());
                _stats.Add(GetDexterity());
                _stats.Add(GetVitality());
                _stats.Add(energy);
                _stats.Add(GetStartingLife());

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(_name);
                    outputFile.WriteLine($"Class: {character}");
                    outputFile.WriteLine($"Strength: {_stats[0]}");
                    outputFile.WriteLine($"Dexterity: {_stats[1]}");
                    outputFile.WriteLine($"Vitality: {_stats[2]}");
                    outputFile.WriteLine($"Energy: {energy}");
                    outputFile.WriteLine($"Starting LifePoints: {_stats[3]}");
                }
                break;
            case "diablo 3":
                _stats.Add(GetStrength());
                _stats.Add(GetDexterity());
                _stats.Add(GetVitality());
                _stats.Add(GetIntelligence());

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(_name);
                    outputFile.WriteLine($"Class: {character}");
                    outputFile.WriteLine($"Strength: {_stats[0]}");
                    outputFile.WriteLine($"Dexterity: {_stats[1]}");
                    outputFile.WriteLine($"Vitality: {_stats[2]}");
                    outputFile.WriteLine($"Intelligence: {_stats[3]}");
                }
                break;
            case "diablo 4":
                _stats.Add(GetStrength());
                _stats.Add(GetDexterity());
                _stats.Add(GetWillpower());
                _stats.Add(GetIntelligence());

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(_name);
                    outputFile.WriteLine($"Class: {character}");
                    outputFile.WriteLine($"Strength: {_stats[0]}");
                    outputFile.WriteLine($"Dexterity: {_stats[1]}");
                    outputFile.WriteLine($"Willpower: {_stats[2]}");
                    outputFile.WriteLine($"Intelligence: {_stats[3]}");
                }
                break;
        }
    }
}

public class Journal
{
    public List<string> _userEntries = new List<string>();
    
    public void SaveJournal(string _userEntries)
    {
        Console.WriteLine("WHat would you like to name this Journal?");
        string journalName = Console.ReadLine();
        DateTime _date = DateTime.Now;
        using (StreamWriter outputFile = new StreamWriter(journalName))
        {
            outputFile.WriteLine(_date);
            outputFile.WriteLine(_userEntries);
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the journal you are loading?");
        string journalName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(journalName);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Console.WriteLine(parts[0]);
        }
    }
}
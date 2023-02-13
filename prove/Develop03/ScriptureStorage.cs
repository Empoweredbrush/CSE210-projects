using System.IO;
public class ScriptureStorage
{
    private Dictionary<string, string> _scripture = new Dictionary<string, string>();

    public void DictionaryCreator()
    {
        bool counter = false;

        while (counter != true)
        {
            Console.WriteLine("What is the reference you wish to save?");
            string reference = Console.ReadLine();

            Console.WriteLine("What is the scripture text associated with that reference?");
            string scriptureText = Console.ReadLine();

            _scripture.Add(reference, scriptureText);

            Console.WriteLine("Do you wish to add another scripture to the library?\n(Write yes to add another, or no to quit.)");
            string userResponse = Console.ReadLine();

            if (userResponse == "yes" || userResponse == "Yes" || userResponse == "YES")
            {
                Console.Clear();
                counter = false;
            }
            else if (userResponse == "no" || userResponse == "No" || userResponse == "NO")
            {
                Console.Clear();
                counter = true;
            }
        }
    }
    public void StorageSave()
    {
        string fileName = "Scripture Library";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            _scripture.AsParallel().ForAll(reference => outputFile.WriteLine($"{reference.Key}\n{reference.Value}"));
        }
    }

    public void StorageLoad()
    {
        Dictionary<string, string> loadScripture = new Dictionary<string, string>();
        string fileName = "Scripture Library";
        using (var sr = new StreamReader(fileName))
        {
            string line = null;

            while ((line = sr.ReadLine()) != null)
            {
                loadScripture.Add(line, sr.ReadLine());
            }
        }

        foreach(var text in loadScripture)
        {
            Console.WriteLine($"{text.Key} : {text.Value}\n");
        }
    }
}
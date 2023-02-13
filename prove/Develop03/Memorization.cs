public class Memorization
{
    private Dictionary<string, string> _scripture = new Dictionary<string, string>();

    public void MemoryGame()
    {
        string fileName = "Scripture Library";
        using (var sr = new StreamReader(fileName))
        {
            string line = null;

            while ((line = sr.ReadLine()) != null)
            {
                _scripture.Add(line, sr.ReadLine());
            }
        }

        Console.WriteLine("Which scripture in your library would you like to work on memorizing today? (Please type in the exact reference)");
        string usersResponse = Console.ReadLine();

        try
        {
            _scripture.ContainsKey(usersResponse);
        }
        catch(KeyNotFoundException)
        {
            Console.WriteLine("Please enter a valid key");
        }

        string scriptureText = _scripture[usersResponse];

        string[] scriptureArray = scriptureText.Split(' ');
        int arrayLength = scriptureArray.Length;

        Console.Clear();
        Console.WriteLine(scriptureText);
        Console.WriteLine("\nPress enter when you are ready for words to be removed. Type quit when you want to stop the program.");
        int counter = 0;
        string quit = null;
        while (counter == 0)
        {
            if (quit != "quit" || quit != "Quit" || quit != "QUIT")
            {
                Console.Clear();
                scriptureText = HideWords(scriptureText, arrayLength, scriptureArray);
                Console.WriteLine(scriptureText);
                quit = Console.ReadLine();
                if (quit == "quit" || quit == "Quit" || quit == "QUIT")
                {
                    counter++;
                }
            }
        }
    }

    private string HideWords(string scripture, int length, string[] array)
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(length);
        string word = array[randomIndex];
        return scripture.Replace(word, "__");

    }
}
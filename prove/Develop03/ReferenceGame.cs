public class ReferenceGame
{
    private Dictionary<string, string> _scriptures = new Dictionary<string, string>();

    public void ReferenceTest()
    {
        string fileName = "Scripture Library";
        using (var sr = new StreamReader(fileName))
        {
            string line = null;

            while ((line = sr.ReadLine()) != null)
            {
                _scriptures.Add(line, sr.ReadLine());
            }
        }

        Console.WriteLine("Welcome to the Reference Game, the game is simple, you will be given a scripture and you must enter the reference that matches the scripture.\nIf you get it right you get a point, if not you don't get any.\nWhen your ready press enter.");
        string enterStart = Console.ReadLine();
        int points = 0;
        int dictLength = _scriptures.Count;
        int counter = 0;

        while (counter != dictLength)
        {
            string scriptureText = RandomDictionary();

            Console.WriteLine(scriptureText);
            string userAnswer = Console.ReadLine();
            bool keyAnswer = _scriptures.ContainsKey(userAnswer);
            if (keyAnswer == true)
            {
                Console.Clear();
                Console.WriteLine("Good Job!!");
                points++;
                counter++;
                Console.WriteLine("When your ready press Enter");
                string input = Console.ReadLine();
            }
            else if (keyAnswer == false)
            {
                Console.WriteLine("Oops try again.");
            }
        }

        Console.WriteLine($"Good job you got {points} points out of {dictLength} points possible");


    }

    private string RandomDictionary()
    {
        Random randomKey = new Random();
        string keyText = _scriptures.ElementAt(randomKey.Next(0, _scriptures.Count)).Value;
        return keyText;
    }
}
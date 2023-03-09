public class Reflection : ActivityMenu
{
    private string[] promptList = new string[] {"Think of a time where you succeeded in something after lots of work", "Think of a time where you reolved a problem as you thought it over"};

    private string[] questionList = new string[] {"What did you do before being able to succeed or resolve the problem you were working through"};
    public Reflection(string name, int seconds) : base(name, seconds)
    {
    }

    public void ReflectionActivity()
    {
        Console.WriteLine($"Welcome {GetName()} to the Reflection Activity!\nThe exercise will give you a random prompt where you will think about how it applies to your life. If there is time, you will be given a few questions to further reflect on the prompt.\nWhen your ready please hit ENTER");

        string enterPress = Console.ReadLine();
        Console.Clear();

        Random randNumber = new Random();
        int index = randNumber.Next(2) - 1;

        while(GetCurrentTime() < GetEndTime())
        {
            Console.WriteLine(promptList[index]);
            Thread.Sleep(10000);

            Console.WriteLine(questionList[0]);
            Thread.Sleep(10000);
        }

        Console.WriteLine(GetEndMessage());


        
    }
}
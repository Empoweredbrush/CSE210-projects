public class Listing : ActivityMenu
{
    private string[] questionList = new string[] {"What times have you seen miracles happen in your life?", "When have you served others?", "When were the times you did simple things for others?"};
    public Listing(string name, int seconds) : base(name, seconds)
    {
    }

    public void ListingActivity()
    {
        Console.WriteLine($"Hello {GetName()} welcome to the Listing activity!\nThis activity will ask you to list items in answer to a question or more. Before starting please grab a pen or pencil and a piece of paper. When your ready please press Enter.");
        string enterPush = Console.ReadLine();

        Random randNum = new Random();
        int index = randNum.Next(4) - 1;
        while(GetCurrentTime() < GetEndTime())
        {
            Console.Clear();
            Console.WriteLine(questionList[index]);
        }

        Console.WriteLine(GetEndMessage());
    }
}
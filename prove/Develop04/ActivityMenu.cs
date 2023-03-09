public class ActivityMenu
{
    private string _name;
    private DateTime _startTime = DateTime.Now;
    private DateTime _endTime;

    private DateTime _currentTime = DateTime.Now;
    private string _endMessage = "Thank you for participating in the program!\nHopefully this program was helpeful and if you wish to start another activity please restart the program.";

    public ActivityMenu(string name, int seconds)
    {
        _name = name;
        _endTime = _startTime.AddSeconds(seconds);
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }
    public string GetName()
    {
        return _name;
    }

    public DateTime GetEndTime()
    {
        return _endTime;
    }

    public DateTime GetCurrentTime()
    {
        return _currentTime;
    }

    public void Menu()
    {
        Console.WriteLine($"Hello {_name}, welcome to the Mindfulness program!\nThis program is meant to guide you through a your choice of activity to help brin g more mindfulness into your life.\nBelow are the activities, please choose the associated number in the menu.\n1. Breathing Activity: an activity that will bring peace to your mind through a breathing exercise.\n2. Reflection Activity: an activity where you will reflect on certain topics.\n3. Listing Activity: an activity where you will list items in answer to one or several questions.");
    }
}
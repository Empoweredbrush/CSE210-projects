public class Breathing : ActivityMenu
{
    public Breathing(string name, int seconds) : base(name, seconds)
    {
    }

    public void BreathingActivity()
    {
        Console.WriteLine($"Hello {GetName()}! Welcome to the breathing activity!\nThis activity will be a breathing exercise. For the span of this activity you will be directed to breath in and out.\nWhen your ready press ENTER.");
        string enterPress = Console.ReadLine();

        string[] breathingArt = new string[] {
            @"
          _          _          
         /\ \       /\ \     _  
         \ \ \     /  \ \   /\_\
         /\ \_\   / /\ \ \_/ / /
        / /\/_/  / / /\ \___/ / 
       / / /    / / /  \/____/  
      / / /    / / /    / / /   
     / / /    / / /    / / /    
 ___/ / /__  / / /    / / /     
/\__\/_/___\/ / /    / / /      
\/_________/\/_/     \/_/       
                                
",
@"
         _      _                _       
        /\ \   /\_\             /\ \     
       /  \ \ / / /         _   \_\ \    
      / /\ \ \\ \ \__      /\_\ /\__ \   
     / / /\ \ \\ \___\    / / // /_ \ \  
    / / /  \ \_\\__  /   / / // / /\ \ \ 
   / / /   / / // / /   / / // / /  \/_/ 
  / / /   / / // / /   / / // / /        
 / / /___/ / // / /___/ / // / /         
/ / /____\/ // / /____\/ //_/ /          
\/_________/ \/_________/ \_\/           
                                         
"
        };

        int indexCounter = 0;

        while (GetCurrentTime() < GetEndTime())
        {
            Console.Clear();
            Console.WriteLine(breathingArt[indexCounter]);
            indexCounter++;
            Thread.Sleep(8000);

            Console.Clear();
            Console.WriteLine(breathingArt[indexCounter]);
            indexCounter = 0;
            Thread.Sleep(8000);
        }

        Console.WriteLine(GetEndMessage());

    }
}
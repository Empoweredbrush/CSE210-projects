using System;
//Project Name: Diablo Character Creator
//Description: The program is designed to aid new players, and possibly older players(being those who have more experience in the game) in creating a character and helping with building characters in certain ways.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to the Diablo Character Creator and Tracker!\nThe goal of this program is to help both old and new players to the Diablo series in creating a character or keeping track of characters before and during play.\nFor new players, this program is meant to help you get an idea of what classes are available to play as, and what sort of abilities and playstyle they bring.\nBelow are the various available games, please enter the number associated with the game from the list below.");
        Console.WriteLine("1. Diablo 1");
        Console.WriteLine("2. Diablo 2");
        Console.WriteLine("3. Diablo 3");
        Console.WriteLine("4. Diablo 4");

        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice)
        {
            case 1:
                Diablo1 diablo1 = new Diablo1();
                diablo1.CharacterCreate();
                break;
            case 2:
                Diablo2 diablo2 = new Diablo2();
                diablo2.CharacterCreate();
                break;
            case 3:
                Diablo3 diablo3 = new Diablo3();
                diablo3.CharacterCreate();
                break;
            case 4:
                Diablo4 diablo4 = new Diablo4();
                diablo4.CharacterCreator();
                break;
        }


    }
}
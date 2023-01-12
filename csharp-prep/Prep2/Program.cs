using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());

        char letter;
        int lastDigit = gradePercentage % 10;
        char gradeLetter;

        if (gradePercentage >= 90){
            letter = 'A';
        }
        else if (gradePercentage >= 80){
            letter = 'B';
        }
        else if (gradePercentage >= 70){
            letter = 'C';
        }
        else if (gradePercentage >= 60){
            letter = 'D';
        }
        else if (gradePercentage < 60){
            letter = 'F';
        }
        else {
            letter = 'N';
        }

        if (gradePercentage >= 90 && lastDigit < 3) {
            gradeLetter = '-';
        }
        else if (gradePercentage >= 80 && lastDigit >= 7) {
            gradeLetter = '+';
        }
        else if (gradePercentage >= 80 && lastDigit < 3) {
            gradeLetter = '-';
        }
        else if (gradePercentage >= 70 && lastDigit >= 7) {
            gradeLetter = '+';
        }
        else if (gradePercentage >= 70 && lastDigit < 3) {
            gradeLetter = '-';
        }
        else if (gradePercentage >= 60 && lastDigit >= 7) {
            gradeLetter = '+';
        }
        else if (gradePercentage >= 60 && lastDigit < 3) {
            gradeLetter = '-';
        }
        else {
            gradeLetter = ' ';
        }

        Console.WriteLine($"Your grade is a {letter}{gradeLetter}");

        if (letter == 'A') {
            Console.WriteLine("Great Job keep up the good work!!");
        }
        else if (letter == 'B') {
            Console.WriteLine("Doing Good!!");
        }
        else if (letter == 'C') {
            Console.WriteLine("There is room for improvement but your passing.");
        }
        else if (letter == 'D') {
            Console.WriteLine("Needs some work but not far off from the mark.");
        }
        else if (letter == 'F') {
            Console.WriteLine("Definitely will need some work but don't lose hope you got this!!");
        }
    }
}
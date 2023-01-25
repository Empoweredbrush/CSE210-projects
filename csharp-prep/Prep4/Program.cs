using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        int listNumber = 1;
        while (listNumber != 0) {
            Console.WriteLine("Please enter a number. Enter 0 when finished.");
            listNumber = int.Parse(Console.ReadLine());
            if (listNumber != 0) {
                numbers.Add(listNumber);
            }
            else if (listNumber == 0) {
                break;
            }
            else {
                Console.WriteLine("Put in valid number.");
            }
        }

        int listSum = numbers.Sum();
        Console.WriteLine($"The sum is: {listSum}");

        double listAverage = numbers.Average();
        Console.WriteLine($"The average is: {listAverage}");

        int listMax = numbers.Max();
        Console.WriteLine($"The largest number is: {listMax}");
    }
}
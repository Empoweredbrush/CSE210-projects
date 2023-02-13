using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Joseph Prep", "Science", "Section 4.5", "Problemts 1-20");
        Assignment schoolWork = new Assignment("Shon Ashby", "Computer Science");
        WritingAssignment writing1 = new WritingAssignment("SHon Ashby", "ENglish", "WHy you should buy a Walker Mower");
        Console.WriteLine(schoolWork.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine(writing1.GetWritingInformation());



    }
}
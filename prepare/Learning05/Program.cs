using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment("Hugo Reyes", "Trigonometry", "Section 4.3", "Problems 45-78");
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine(mathAssignment1.GetSummary());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mishell García", "School Organization", "How to propperly organize the Archive");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine(writingAssignment1.GetSummary());
    }
}
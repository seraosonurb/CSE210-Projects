using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Bruno Soares", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Daniella Bizzon", "ENEME Essay", "How to live to 100 years");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingIinformation());




    }
}
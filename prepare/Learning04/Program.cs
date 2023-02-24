using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Adam Potts ", "Homemaking");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Kathleen Potts ", "Times-Tables", "1.2", "7-8");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Melody Potts ", "Research Paper", "How sleeping through class is helpful");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
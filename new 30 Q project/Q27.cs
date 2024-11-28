using System;

class HelloWorld {
    static void Main() {
        int english, urdu, math, pst, programming;

        Console.Write("Enter marks for English: ");
        english = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Urdu: ");
        urdu = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Math: ");
        math = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for PST: ");
        pst = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Programming: ");
        programming = int.Parse(Console.ReadLine());

        int totalMarks = english + urdu + math + pst + programming;
        double percentage = (double)totalMarks / 500 * 100;

        int gradeRange = (int)(percentage / 10); // Divide percentage by 10 to get the grade range (e.g., 90-100 becomes 9)

        char grade;

        switch (gradeRange)
        {
            case 10:
            case 9:
                grade = 'A';
                break;
            case 8:
                grade = 'B';
                break;
            case 7:
                grade = 'C';
                break;
            case 6:
                grade = 'D';
                break;
            case 5:
                grade = 'E';
                break;
            default:
                grade = 'F';
                break;
        }

        Console.WriteLine("Total Marks: " +totalMarks);
        Console.WriteLine($"Percentage: " +percentage );
        Console.WriteLine($"Grade: " +grade);
    }
}

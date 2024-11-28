/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {


        Console.Write("Enter Your Name: ");
        string studentName = Console.ReadLine();
        Console.WriteLine("Student Name: " + studentName);


        Console.Write("Enter Your English Marks: ");
        int eng = int.Parse(Console.ReadLine());

        Console.Write("Enter Your Urdu Marks: ");
        int urdu = int.Parse(Console.ReadLine());

        Console.Write("Enter Your Math Marks: ");
        int math = int.Parse(Console.ReadLine());

        Console.Write("Enter Your PST Marks: ");
        int pst = int.Parse(Console.ReadLine());

        Console.Write("Enter Your Programming Marks: ");
        int programming = int.Parse(Console.ReadLine());

     
        int totalMarks = 500; 
        int obtainedMarks = eng + urdu + math + pst + programming;
        double percentage = (double)obtainedMarks / totalMarks * 100;

      
        Console.WriteLine("\nMarks Breakdown:");
        Console.WriteLine("English Marks = " + eng);
        Console.WriteLine("Urdu Marks = " + urdu);
        Console.WriteLine("Mathematics Marks = " + math);
        Console.WriteLine("PST Marks = " + pst);
        Console.WriteLine("Programming Marks = " + programming);


        Console.WriteLine("\nObtained Marks = " + obtainedMarks);
        Console.WriteLine("Percentage = " + percentage.ToString("F2") + "%");


        Console.Write("\nGrade: ");
        if (percentage >= 80 && percentage <= 100)
        {
            Console.WriteLine("A+");
        }
        else if (percentage >= 70 && percentage < 80)
        {
            Console.WriteLine("A");
        }
        else if (percentage >= 60 && percentage < 70)
        {
            Console.WriteLine("B");
        }
        else if (percentage >= 50 && percentage < 60)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("Fail. Better luck next time.");
    }
      
  }
}



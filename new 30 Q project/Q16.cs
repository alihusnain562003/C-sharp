using System;

class HelloWorld {
    static void Main() {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your driving test result (Pass/Fail): ");
        string testResult = Console.ReadLine().ToLower();  

        if (age >= 18 && testResult == "pass")
        {
            Console.WriteLine("You are eligible for a driving license.");
        }
        else if (age < 18)
        {
            Console.WriteLine("You are not eligible for a driving license due to age.");
        }
        else if (testResult != "pass")
        {
            Console.WriteLine("You are not eligible for a driving license because you did not pass the test.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please ensure you enter a valid test result.");
        }
    }
}

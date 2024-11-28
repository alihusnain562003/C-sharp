using System;

class HelloWorld {
    static void Main() {
        Console.Write("Enter a number to check divisibility by 5 and 11: ");
        int number = int.Parse(Console.ReadLine());


        if (number % 5 == 0 && number % 11 == 0)
        {
            Console.WriteLine("The number  is divisible by both 5 and 11.");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("The number is divisible by 5 but not by 11.");
        }
        else if (number % 11 == 0)
        {
            Console.WriteLine($"The number is divisible by 11 but not by 5.");
        }
        else
        {
            Console.WriteLine("The number is not divisible by either 5 or 11.");
        }
    }
}


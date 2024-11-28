using System;

class HelloWorld {
    static void Main() {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

        Console.WriteLine("The largest number is: " + largest);
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an operation: ");
        Console.WriteLine("ADD, SUBTRACT, DIVIDE, MULTIPLY, SQUARE, CUBE, AVERAGE");
        string operation = Console.ReadLine().ToUpper();

        if (operation == "ADD" || operation == "SUBTRACT" || operation == "DIVIDE" || operation == "MULTIPLY")
        {
            Console.WriteLine("Enter the first number:");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input for the first number.");
                return;
            }

            Console.WriteLine("Enter the second number:");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input for the second number.");
                return;
            }

            if (operation == "ADD")
                Console.WriteLine($"Result: {Add(num1, num2)}");
            else if (operation == "SUBTRACT")
                Console.WriteLine($"Result: {Subtract(num1, num2)}");
            else if (operation == "DIVIDE")
                Console.WriteLine(num2 != 0 ? $"Result: {Divide(num1, num2)}" : "Error: Division by zero is not allowed.");
            else if (operation == "MULTIPLY")
                Console.WriteLine($"Result: {Multiply(num1, num2)}");
        }
        else if (operation == "SQUARE" || operation == "CUBE")
        {
            Console.WriteLine("Enter the number:");
            double num;
            if (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input for the number.");
                return;
            }

            if (operation == "SQUARE")
                Console.WriteLine($"Result: {Square(num)}");
            else if (operation == "CUBE")
                Console.WriteLine($"Result: {Cube(num)}");
        }
        else if (operation == "AVERAGE")
        {
            Console.WriteLine("How many numbers do you want to average?");
            int count;
            if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Invalid input for the count of numbers.");
                return;
            }

            double[] numbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                if (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input for one of the numbers.");
                    return;
                }
            }

            Console.WriteLine($"Result: {Average(numbers)}");
        }
        else
        {
            Console.WriteLine("Invalid operation selected.");
        }
    }


    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Divide(double a, double b) => a / b;
    static double Multiply(double a, double b) => a * b;
    static double Square(double a) => a * a;
    static double Cube(double a) => a * a * a;
    static double Average(double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }
}

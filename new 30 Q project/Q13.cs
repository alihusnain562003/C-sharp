using System;

class HelloWorld {
    static void Main() {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /, %): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // To move to the next line after the operator input

        // Use string interpolation with $ to include variables in the output
        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                break;

            case '-':
                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                break;

            case '*':
                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                break;

            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            case '%':
                if (num2 != 0)
                {
                    Console.WriteLine($"Result: {num1} % {num2} = {num1 % num2}");
                }
                else
                {
                    Console.WriteLine("Error: Modulus by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Error: Invalid operator. Please use +, -, *, /, or %.");
                break;
        }
    }
}

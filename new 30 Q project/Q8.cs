using System;
class HelloWorld {
  static void Main() {

       Console.Write("Enter your First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose an operation (+, -, *, /) or (add, sub, mul, div): ");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
            case "add":
                int add = num1 + num2;
                Console.WriteLine("Your Addition Answer is: " + add);
                break;

            case "-":
            case "sub":
                int sub = num1 - num2;
                Console.WriteLine("Your Subtraction Answer is: " + sub);
                break;

            case "*":
            case "mul":
                int mul = num1 * num2;
                Console.WriteLine("Your Multiplication Answer is: " + mul);
                break;

            case "/":
            case "div":
                if (num2 != 0)
                {
                    int div = num1 / num2;
                    Console.WriteLine("Your Division Answer is: " + div);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid operation selected.");
                break;
        }
  }
}

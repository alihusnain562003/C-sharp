/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
   
        Console.WriteLine("Currency Converter");
        Console.WriteLine("1. USD to EUR");
        Console.WriteLine("2. USD to GBP");
        Console.WriteLine("3. EUR to USD");
        Console.WriteLine("4. EUR to GBP");
        Console.WriteLine("5. GBP to USD");
        Console.WriteLine("6. GBP to EUR");
        Console.Write("Enter your choice (1-6): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter amount: ");
        double amount = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"{amount} USD = {amount * 0.93} EUR");
                break;
            case 2:
                Console.WriteLine($"{amount} USD = {amount * 0.83} GBP");
                break;
            case 3:
                Console.WriteLine($"{amount} EUR = {amount * 1.08} USD");
                break;
            case 4:
                Console.WriteLine($"{amount} EUR = {amount * 0.89} GBP");
                break;
            case 5:
                Console.WriteLine($"{amount} GBP = {amount * 1.20} USD");
                break;
            case 6:
                Console.WriteLine($"{amount} GBP = {amount * 1.12} EUR");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

  }
}
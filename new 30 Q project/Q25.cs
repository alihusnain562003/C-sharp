

using System;
class HelloWorld {
  static void Main() {

    
       double balance = 1000.00; // Initial balance
        int pin = 1234; // Pre-set ATM pin
        int enteredPin;

        Console.Write("Enter ATM PIN: ");
        enteredPin = int.Parse(Console.ReadLine());

        if (enteredPin != pin)
        {
            Console.WriteLine("Incorrect PIN. Access Denied.");
            return;
        }

        int choice;
        do
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your balance is: ${balance}");
                    break;

                case 2:
                    Console.Write("Enter deposit amount: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine($"You have deposited ${depositAmount}. Your new balance is ${balance}.");
                    break;

                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawalAmount = double.Parse(Console.ReadLine());
                    if (withdrawalAmount <= balance)
                    {
                        balance -= withdrawalAmount;
                        Console.WriteLine($"You have withdrawn ${withdrawalAmount}. Your new balance is ${balance}.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting. Thank you for using the ATM.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        while (choice != 4);
  }
}
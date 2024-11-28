using System;

class HelloWorld {
    static void Main() {

        Console.Write("Enter years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        Console.Write("Enter the employee's salary: ");
        double salary = double.Parse(Console.ReadLine());


        double bonus;

        if (yearsOfService >= 5)
        {
            bonus = salary * 0.10; 
        }
        else
        {
            bonus = salary * 0.05; 
        }

    
        Console.WriteLine("The bonus for the employee is:"+ bonus);
    }
}

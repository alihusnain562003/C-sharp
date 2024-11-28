/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {

    
    
    

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("The greater number is: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The greater number is: " + num2);
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }
}


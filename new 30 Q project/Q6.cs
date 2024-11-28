/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {

 Console.WriteLine("Enter a value to see if it's a positive or negative number:");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value > 0)
        {
            Console.WriteLine("Positive number: " + value);
        }
        else if (value < 0)
        {
            Console.WriteLine("Negative number: " + value);
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}



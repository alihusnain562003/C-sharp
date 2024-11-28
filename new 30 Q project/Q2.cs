/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {

    
    
    
    
        Console.WriteLine("Enter a value to check if it's even or odd:");
        int checknum = Convert.ToInt32(Console.ReadLine());
        if (checknum % 2 == 0)
        {
            Console.WriteLine(checknum + " is an Even number.");
        }
        else
        {
            Console.WriteLine(checknum + " is an Odd number.");
        }
    }
}

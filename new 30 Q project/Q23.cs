

using System;
class HelloWorld {
  static void Main() {

    
    Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is positive and even.");
            }
            else
            {
                Console.WriteLine("The number is positive and odd.");
            }
        }
        else if (num < 0)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is negative and even.");
            }
            else
            {
                Console.WriteLine("The number is negative and odd.");
            }
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

  }
}
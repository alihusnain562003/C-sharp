using System;

class HelloWorld {
    static void Main() {
        Console.Write("Enter your 1st item price: ");
        int item1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your 2nd item price: ");
        int item2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your 3rd item price: ");
        int item3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your 4th item price: ");
        int item4 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your 5th item price: ");
        int item5 = Convert.ToInt32(Console.ReadLine());

        int price = item1 + item2 + item3 + item4 + item5;
        
        Console.WriteLine("Your Actual Price is" + price);

        if (price > 25000) {
            double discount = 0.25 * price; // 25% discount
            double discountedPrice = price - discount;
            Console.WriteLine("Your discounted price is: " + discountedPrice);
        } else {
            Console.WriteLine("Your total price is: " + price);
        }
    }
}

CALCULATOR

/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        Console.Write("Enter your First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int add = num1 + num2;
        int sub = num1 - num2;
        int mul = num1 * num2;
        int div = num1 / num2;

        Console.WriteLine("Your Addition Answer is: " + add);
        Console.WriteLine("Your Subtraction Answer is: " + sub);
        Console.WriteLine("Your Multiplication Answer is: " + mul);
        Console.WriteLine("Your Division Answer is: " + div);

  }
}
MULTIPLICATION TABLE

Console.WriteLine("Enter your num : ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int mulby1 = num * 1;
        int mulby2 = num * 2 ;
        int mulby3 = num * 3;
        int mulby4 = num * 4 ; 
        int mulby5 = num * 5;
        int mulby6 = num * 6;
        int mulby7 = num * 7;
        int mulby8 = num * 8;
        int mulby9 = num * 9;
        int mulby10 = num * 10;
        
        Console.WriteLine(mulby1);
        Console.WriteLine(mulby2);
        Console.WriteLine(mulby3);
        Console.WriteLine(mulby4);
        Console.WriteLine(mulby5);
        Console.WriteLine(mulby6);
        Console.WriteLine(mulby7);
        Console.WriteLine(mulby8);
        Console.WriteLine(mulby9);
        Console.WriteLine(mulby10);
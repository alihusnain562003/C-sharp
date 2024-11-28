

using System;
class HelloWorld {

   
    static void Main()
    {
        Console.Write("Enter the number of units consumed: ");
        int units = int.Parse(Console.ReadLine());

        double billAmount;

        if (units <= 100)
        {
            billAmount = units * 1.5;
        }
        else if (units <= 200)
        {
            billAmount = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else if (units <= 300)
        {
            billAmount = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 3.5);
        }
        else
        {
            billAmount = (100 * 1.5) + (100 * 2.5) + (100 * 3.5) + ((units - 300) * 4.5);
        }

        Console.WriteLine("The total electricity bill is: {billAmount} units.");

  }
}
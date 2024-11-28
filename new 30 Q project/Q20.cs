using System;

class HelloWorld {
    static void Main() {
   Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        switch (num % 2)
        {
            case 0:
                Console.WriteLine("The number is even.");
                break;
            case 1:
                Console.WriteLine("The number is odd.");
                break;
        }


    }
}

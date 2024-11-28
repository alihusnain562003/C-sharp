using System;
class HelloWorld {
  static void Main() {

        Console.Write("Enter your Number (1 till 7 or one till seven): ");
        string input = Console.ReadLine().ToLower(); 

        switch (input)
        {
            case "1":
            case "one":
              Console.WriteLine("Monday");
              break;

            case "2":
            case "two":
              Console.WriteLine("Tuesday");
              break;

            case "3":
            case "three":
              Console.WriteLine("Wednesday");
              break;

            case "4":
            case "four":
              Console.WriteLine("Thursday");
              break;

            case "5":
            case "five":
              Console.WriteLine("Friday");
              break;

            case "6":
            case "six":
              Console.WriteLine("Saturday");
              break;

            case "7":
            case "seven":
              Console.WriteLine("Sunday");
              break;

            default:
              Console.WriteLine("Invalid Number.");
              break;
        }
  }
}

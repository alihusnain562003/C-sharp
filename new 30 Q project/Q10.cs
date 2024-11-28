using System;

class HelloWorld {
    static void Main() {

        Console.Write("Enter a number from 1 to 12 (or write it in words): ");
        string input = Console.ReadLine()?.ToLower(); 
        
   
        switch (input)
        {
            case "1":
            case "one":
                Console.WriteLine("January");
                break;

            case "2":
            case "two":
                Console.WriteLine("February");
                break;

            case "3":
            case "three":
                Console.WriteLine("March");
                break;

            case "4":
            case "four":
                Console.WriteLine("April");
                break;

            case "5":
            case "five":
                Console.WriteLine("May");
                break;

            case "6":
            case "six":
                Console.WriteLine("June");
                break;

            case "7":
            case "seven":
                Console.WriteLine("July");
                break;

            case "8":
            case "eight":
                Console.WriteLine("August");
                break;

            case "9":
            case "nine":
                Console.WriteLine("September");
                break;

            case "10":
            case "ten":
                Console.WriteLine("October");
                break;

            case "11":
            case "eleven":
                Console.WriteLine("November");
                break;

            case "12":
            case "twelve":
                Console.WriteLine("December");
                break;

            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 12 or its word equivalent.");
                break;
        }
    }
}


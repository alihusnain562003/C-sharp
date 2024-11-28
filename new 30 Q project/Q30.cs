using System;

class HelloWorld {
    static void Main() {

   
        Console.Write("Enter a word or number to check if it's a palindrome: ");
        string input = Console.ReadLine();


        string processedInput = input.Replace(" ", "").ToLower();

        char[] charArray = processedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);


        if (processedInput == reversedInput)
        {
            Console.WriteLine(input +"is a palindrome.");
        }
        else
        {
            Console.WriteLine(input +" is not a palindrome.");
        }
      
    }
}

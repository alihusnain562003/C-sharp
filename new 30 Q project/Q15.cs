
using System;

class CharacterClassification
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        

        char inputChar = Console.ReadKey().KeyChar;  
        Console.WriteLine();


        if (Char.IsUpper(inputChar))
        {
            Console.WriteLine("The character is an uppercase letter.");
        }
        else if (Char.IsLower(inputChar))
        {
            Console.WriteLine("The character is a lowercase letter.");
        }
        else if (Char.IsDigit(inputChar))
        {
            Console.WriteLine("The character is a digit.");
        }
        else
        {
            Console.WriteLine("The character is a special character.");
        }
    }
}



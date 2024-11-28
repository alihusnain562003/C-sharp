using System;

class HelloWorld {
    static void Main() {
Console.Write("Enter a character: ");
char inputChar = char.Parse(Console.ReadLine().ToLower());

switch (inputChar)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine($"The character '{inputChar}' is a vowel.");
        break;
    default:
        if (char.IsLetter(inputChar))
        {
            Console.WriteLine($"The character '{inputChar}' is a consonant.");
        }
        else
        {
            Console.WriteLine($"The character '{inputChar}' is not a valid alphabet letter.");
        }
        break;
}

    }
}


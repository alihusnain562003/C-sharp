using System;

class HelloWorld {
    static void Main() {
         Console.Write("Enter the traffic light color (Red, Yellow, Green): ");
        string lightColor = Console.ReadLine().ToLower();  // Convert to lowercase to handle case insensitivity

        switch (lightColor)
        {
            case "red":
                Console.WriteLine("Stop! The light is red.");
                break;

            case "yellow":
                Console.WriteLine("Caution! The light is yellow.");
                break;

            case "green":
                Console.WriteLine("Go! The light is green.");
                break;

            default:
                Console.WriteLine("Invalid input! Please enter Red, Yellow, or Green.");
                break;
        }
    }
}

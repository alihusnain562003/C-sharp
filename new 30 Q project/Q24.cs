

using System;
class HelloWorld {
  static void Main() {

    
          Console.Write("Enter x-coordinate: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y-coordinate: ");
        double y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point lies in Quadrant I.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point lies in Quadrant II.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point lies in Quadrant III.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point lies in Quadrant IV.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("The point lies on the Y-axis.");
        }
        else if (y == 0 && x != 0)
        {
            Console.WriteLine("The point lies on the X-axis.");
        }
        else
        {
            Console.WriteLine("The point lies at the origin.");
        }
  }
}
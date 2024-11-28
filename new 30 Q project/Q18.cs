using System;

class HelloWorld {
    static void Main() {


        Console.Write("Enter weight in kg: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in feet: ");
        int feet = int.Parse(Console.ReadLine());

        Console.Write("Enter height in inches: ");
        int inches = int.Parse(Console.ReadLine());


        int totalInches = (feet * 12) + inches;
        double totalCms = totalInches * 2.54; 
        double heightInMeters = totalCms / 100; 
   
        double bmi = weight / (heightInMeters * heightInMeters);

     


        string result;
        if (bmi < 18)
        {
            result = "Underweight - You are underweight.";
        }
        else if (bmi >= 25)
        {
            result = "Overweight - You are overweight.";
        }
        else
        {
            result = "Normal - You are healthy.";
        }

        // Output the BMI category
        Console.WriteLine(result);
    }
}

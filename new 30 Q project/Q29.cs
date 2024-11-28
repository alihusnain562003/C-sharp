using System;

class HelloWorld {
    static void Main() {

        Console.Write("Enter weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in meters: ");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        string healthStatus;

        switch (bmi)
        {
            case double n when (n < 18.5):
                healthStatus = "Underweight";
                break;
            case double n when (n >= 18.5 && n < 24.9):
                healthStatus = "Normal weight";
                break;
            case double n when (n >= 25 && n < 29.9):
                healthStatus = "Overweight";
                break;
            case double n when (n >= 30):
                healthStatus = "Obese";
                break;
            default:
                healthStatus = "Invalid BMI";
                break;
        }

 
        Console.WriteLine("Your BMI is: {bmi:F2}");
        Console.WriteLine("Health Status: {healthStatus}");
    }
}

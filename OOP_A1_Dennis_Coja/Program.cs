1.)
using System;
class Program
{
    static void Main()
    {
        Console.Write("Please enter your birth year: ");
        int birthYear;

        if (int.TryParse(Console.ReadLine(), out birthYear))
        {
            int currentYear = DateTime.Now.Year;

            int age = currentYear - birthYear;

            DateTime birthDate = new DateTime(birthYear, 1, 1);
            DateTime today = DateTime.Now;
            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            Console.WriteLine($"You are {age} years old.");
        }
        else
        {
            Console.WriteLine("Incorrect input. Please enter a correct year.");
        }
    }
}

2.)
using System;
using System.Text;
using System.Threading.Tasks;
 
namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue calculating? press 1 if you would like to continue if not press 2(1/2):");
                value = Console.ReadLine();
            }
            while (value == "1" || value == "1");
        }
    }

}
3.  )
using System; 
class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Please Enter Radius: ");
        double rad = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * rad * rad;
        Console.WriteLine("Area of circle is: " + area);
    }
}


4.)
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter an interger that you desire to put in: ");
        int number;

        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Incorrect input. Please enter a correct integer.");
        }
    }
}


5.)
using System;
class Program
{
    static void Main()
    {
        Console.Write("Please input your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Please input your last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        Console.WriteLine($"Full Name: {fullName}");
    }
}

6.)
using System;
namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxRate = 0.08;

            Console.Write("Please input the price of the item: ");

            if (double.TryParse(Console.ReadLine(), out double itemPrice))
            {
                double taxAmount = itemPrice * taxRate;

                double totalPrice = itemPrice + taxAmount;

                Console.WriteLine($"Price of the item: ${itemPrice:F2}");
                Console.WriteLine($"Tax amount (8%): ${taxAmount:F2}");
                Console.WriteLine($"Total price: ${totalPrice:F2}");
            }
            else
            {
                Console.WriteLine("Incorrect input. Please input a valid number.");
            }
        }
    }
}

7.)
using System;
namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight (Kilogram): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Please enter your height (Meters): ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine($"Your final BMI is: {bmi:F2}");
        }
    }
}


8.)
using System;
 
namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Press A for Celsius to Fahrenheit");
            Console.WriteLine("Press B for Fahrenheit to Celsius");
            Console.Write("Choose Conversion: ");
            string choice = Console.ReadLine();

            if (choice == "A")
            {
                Console.Write("Please you're enter temperature in Celsius: ");
                if (double.TryParse(Console.ReadLine(), out double celsius))
                {
                    double fahrenheit = CelsiusToFahrenheit(celsius);
                    Console.WriteLine($"Original temperature: {celsius}°C");
                    Console.WriteLine($"Converted temperature: {fahrenheit:F2}°F");
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please input a numeric value.");
                }
            }
            else if (choice == "B")
            {
                Console.Write("Please enter you're temperature in Fahrenheit: ");
                if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                {
                    double celsius = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine($"Original temperature: {fahrenheit}°F");
                    Console.WriteLine($"Converted temperature: {celsius:F2}°C");
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please input a numeric value.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter A or B.");
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

9.)
using System;
namespace GradeAverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of subjects: ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfSubjects) || numberOfSubjects <= 0)
            {
                Console.WriteLine("Incorrect input. Please input a positive integer for the number of subjects.");
                return;
            }

            double[] grades = new double[numberOfSubjects];
            double total = 0;

            for (int i = 0; i < numberOfSubjects; i++)
            {
                Console.Write($"Please enter grade for subject {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0)
                {
                    grades[i] = grade;
                    total += grade;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please input a non-negative numeric value for the grade.");
                    i--;
                }
            }

            double average = total / numberOfSubjects;

            Console.WriteLine($"The final average grade is: {average:F2}");
        }
    }
}

10.)

using System;
namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the coefficient a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Please enter the coefficient b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Please enter the coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"The equation has two distinct real roots: x1 = {root1:F2} and x2 = {root2:F2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"The equation has one real root: x = {root:F2}");
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}





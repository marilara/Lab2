using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string question;

            while (repeat)
            {
                // Initialize variables length and width
                double length, width, height;

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
                Console.WriteLine();

                // Request user input for length, width, and height to declare those variables
                Console.WriteLine("Enter the Length");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the Width");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the Height");
                height = Convert.ToDouble(Console.ReadLine());

                // Initialize and declare variables for area and perimeter
                double area = length * width;
                double perimeter = (length * 2) + (width * 2);
                double volume = length * width * height;

                // Print to console the area, perimeter, and volume
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Do you want to continue? (y/n)");
                question = Console.ReadLine();
                
                if (question == "y" || question == "Y")
                {
                    repeat = true;
                } else
                {
                    break;
                }
            }
        }
    }
}

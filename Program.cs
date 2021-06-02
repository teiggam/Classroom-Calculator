using System;

namespace Lab_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to your personal Room Design Calculator");
            Console.WriteLine("");
            Console.WriteLine("Please enter measurement in feet.");
            string again;
            bool goOn = true;
            while (goOn == true)
            {

                try
                {
                    Console.WriteLine("");
                    Console.Write("Enter Length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("");





                    double area = width * length;
                    double perimeter = width + length * 2;
                    double volume = width * length * height;

                    Console.WriteLine("The area is " + area + " square feet.");
                    Console.WriteLine("The perimeter is " + perimeter + " feet.");
                    Console.WriteLine("The volume of the room is: " + volume + " cubic feet.");
                    Console.WriteLine("Carpet Tiles Needed: " + area / 5);
                    Console.WriteLine("Cans of Paint Needed: " + perimeter / 5);
                    Console.WriteLine("");

                    Console.WriteLine("Would you like to calculate another room? (Y/N): ");

                    again = Console.ReadLine().ToLower();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number, please try again.");
                    continue;
                }

                if (again == "y")
                {
                    goOn = true;
                    continue;
                }
                else
                {
                    goOn = false;
                    break;
                }
            }

        }

    }
}

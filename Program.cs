using System;

namespace Lab_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to your personal Room Design Calculator");
            Console.WriteLine("");
            Console.WriteLine("Please enter imperial units in feet.");
            Console.WriteLine("");


            Console.Write("Enter Length:");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + width * length );

            double halfPer = width + length;
            double perimeter = halfPer *2;

            Console.WriteLine("Perimeter: " + perimeter);


              

           


        }
    }
}

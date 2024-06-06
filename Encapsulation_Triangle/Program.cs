using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { Console.WriteLine("Enter the base of the triangle: ");
                double _base = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height of the triangle:");
                double _height = double.Parse(Console.ReadLine());

                Triangle triangle = new Triangle();
                triangle.Base = _base;
                triangle.Height = _height;

                double area = triangle.GetArea();
                Console.WriteLine($"The area of the triangle is : {area} square units");
                    }
            catch (ArgumentException)
            {
                Console.WriteLine("Error");


            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please enter valid numbers");
            }
        }
    }
}

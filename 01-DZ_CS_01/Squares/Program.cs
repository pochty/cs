using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squares in rectangle\n");
            double rectangleSideA = GetUserInput("Input rectangle side A: ");
            double rectangleSideB = GetUserInput("Input rectangle side B: ");
            double squareSide = GetUserInput("Input square side: ");
            if (rectangleSideA < squareSide || rectangleSideB < squareSide)
            {
                Console.WriteLine("There is no square in the rectangle");
            }
            else
            {
                int squaresQnt = (int)(Math.Truncate(rectangleSideA / squareSide) * Math.Truncate(rectangleSideB / squareSide));
                double freeArea = rectangleSideA * rectangleSideB - squaresQnt * squareSide * squareSide;
                Console.WriteLine("Squares quantity: " + squaresQnt + "\n" + "Free area: " + freeArea);
            }
            Console.ReadKey();
        }

        static double GetUserInput(string msg)
        {
            Console.WriteLine(msg);
            double val;
            while (!double.TryParse(Console.ReadLine(), out val) || val < 0)
            {
                Console.WriteLine("Invalid value, try again.\n" + msg);
            }
            return val;
        }
    }
}

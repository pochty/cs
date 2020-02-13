using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int valA = GetUserInput("Input value A: ");
            int valB = GetUserInput("Input value B: ");
            while (valA > valB)
            {
                Console.WriteLine("Value B must be greater than value A. Please, try again");
                valA = GetUserInput("Input value A: ");
                valB = GetUserInput("Input value B: ");
            }
            for (int i = valA; i <= valB; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("\n");
            }
            Console.Read();
        }

        static int GetUserInput(string msg)
        {
            Console.WriteLine(msg);
            int val;
            while (!int.TryParse(Console.ReadLine(), out val) || val < 0)
            {
                Console.WriteLine("Invalid value, try again.\n" + msg);
            }
            return val;
        }

    }
}

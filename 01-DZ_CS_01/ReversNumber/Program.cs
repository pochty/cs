using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = GetUserInput("Input value (integer > 0): ");
            string str = val.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Result:");
            Console.WriteLine(arr);
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

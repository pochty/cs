using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 0;
            double sum = 10000;
            double maxSum = 11000;
            double percent = GetUserInput("Input percent (0..25): ");
            while (percent <= 0 || percent > 25)
            {
                Console.WriteLine("Invalid value, try again.\n");
                percent = GetUserInput("Input percent (0..25): ");
            }
            while (sum < maxSum)
            {
                ++month;
                sum += sum * percent / 100;
            }
            Console.WriteLine("Number of months: " + month + "\nTotal: " + sum);
            Console.Read();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DZ_CS_02
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Shrink array\n2. Sort array\n3. Count element in array\n4. Change columns\n0. Exit\n");
                int[] arr = { 0, 10, 2, 40, 1, 9, -6, 5, 0, 3, 4, 5, 7, 0, 39, -49, 0, -20 };
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        PrintArray(arr);
                        ShrinkArray(ref arr, 0);
                        PrintArray(arr);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        PrintArray(arr);
                        Array.Sort(arr);
                        PrintArray(arr);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        PrintArray(arr);
                        Console.Write("Input number for search: ");
                        int val;
                        while (!int.TryParse(Console.ReadLine(), out val))
                            Console.Write("Invalid number, try again: ");
                        int count = arr.Count(i => i == val);
                        Console.WriteLine($"Count: {count}");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        int[,] arr2= new int[2,4];
                        Random rand = new Random();
                        for (int i = 0; i < arr2.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr2.GetLength(1); j++)
                            {
                                arr2[i, j] = rand.Next(-100, 100);
                            }
                        }
                        PrintArray(arr2);
                        Console.Write("Input column 1:");
                        int col1;
                        while (!int.TryParse(Console.ReadLine(), out col1) || col1 < 0 || col1 >= arr2.GetLength(1))
                            Console.Write("Invalid input, try again: ");
                        int col2;
                        Console.Write("Input column 2:");
                        while (!int.TryParse(Console.ReadLine(), out col2) || col2 < 0 || col2 >= arr2.GetLength(1))
                            Console.Write("Invalid input, try again: ");
                        for (int i = 0; i < arr2.GetLength(0); i++)
                        {
                            int tmp = arr2[i, col1];
                            arr2[i, col1] = arr2[i, col2];
                            arr2[i, col2] = tmp;
                        }
                        PrintArray(arr2);
                        Console.ReadKey();
                        break;
                    default:
                        return;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ShrinkArray(ref int[] arr, int val)
        {
            int pos = arr.Length - 1;
            for (int i = 0; i < pos; i++)
            {
                if (arr[i] == val)
                {
                    while (arr[pos] == val && pos > 0)
                        --pos;
                    arr[i] = arr[pos];
                    arr[pos] = -1;
                    --pos;
                }
            }
           Array.Resize(ref arr, pos + 1);
        }
    }
}

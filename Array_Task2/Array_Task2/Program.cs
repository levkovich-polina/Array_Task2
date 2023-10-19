using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = InitializeArray(N);
            Console.WriteLine("Изначальный массив:");
            PrintArray(array);
            Console.WriteLine();
            SortArray(array, N);
            Console.WriteLine("Измененный массив:");
            PrintArray(array);
            Console.ReadLine();
        }
        static int[] InitializeArray(int n)
        {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }

            return array;
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static int[] SortArray(int[] array, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                int last = array[i];
                array[i] = array[i + n / 2];
                array[i + n / 2] = last;
            }

            return array;
        }
    }
}

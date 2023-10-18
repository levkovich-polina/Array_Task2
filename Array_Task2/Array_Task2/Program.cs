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
            Random _rnd = new Random();

            Console.WriteLine("Введите количество элементов");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];


            for (int i = 0; i < N; i++)
            {
                array[i] =_rnd.Next(0,101);
            }

            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < N / 2; i++)
            {
                int last = array[i];
                array[i] = array[i + N / 2];
                array[i + N / 2] = last;
            }

            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadLine();
        }
    }
}

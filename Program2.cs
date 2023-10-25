using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMPLab2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int N;
            do
            {
                Console.Write("Введите N (N > 0): ");
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    N = -1;
                }
            } while (N <= 0);
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
                arr[i] = rnd.Next(0, 100);

            Console.WriteLine("\nИсходный массив: ");
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();

            for (int i = 0; i < N / 2; i++)
            {
                int temp = arr[i];
                if (N % 2 == 0)
                {
                    arr[i] = arr[i + N / 2];
                    arr[i + N / 2] = temp;
                }
                else
                {
                    arr[i] = arr[i + 1 + N / 2];
                    arr[i + 1 + N / 2] = temp;
                }
            }

            Console.WriteLine("\nМассив с обменом половин: ");
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMPLab2
{
    internal class Program5
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            const int N = 1000;

            int[] matrix1 = new int[N * N];
            int[] matrix2 = new int[N * N];
            int[] matrix3 = new int[N * N];

            for (int i = 0; i < N * N; i++)
            {
                matrix1[i] = Convert.ToInt32(rnd.Next(0, 10));
                matrix2[i] = Convert.ToInt32(rnd.Next(0, 10));
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        matrix3[i * N + j] += matrix1[i * N + k] * matrix2[k * N + j];
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write($"{matrix3[i * N + j]} ");
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VMPLab2
{
    internal class Program1
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
            int[] arrN = new int[N];
            for (int i = 0; i < N; i++)
                arrN[i] = rnd.Next(0, 100);

            Console.WriteLine("\nМассив N: ");
            foreach (int i in arrN)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            int M;
            do
            {
                Console.Write("Введите M (M > 0): ");
                try
                {
                    M = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    M = -1;
                }
            } while (M <= 0);
            int[] arrM = new int[M];
            for (int i = 0; i < M; i++)
                arrM[i] = rnd.Next(0, 100);

            Console.WriteLine("\nМассив M: ");
            foreach (int i in arrM)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            int K;
            do
            {
                Console.Write($"Введите K (1 <= K <= {N}): ");
                try
                {
                    K = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    K = -1;
                }
            } while (K < 1 || K > N);

            Array.Resize(ref arrN, N + M);

            for (int i = arrN.Length - 1; i > arrN.Length - 1 - (N - K + 1); i--)
                arrN[i] = arrN[i - M];

            for (int i = K - 1; i < K - 1 + M; i++)
                arrN[i] = arrM[i - K + 1];

            Console.Write("\nИтоговый массив: ");
            foreach (int i in arrN)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
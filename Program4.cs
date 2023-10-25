using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMPLab2
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            int n = -1;
            do
            {
                Console.Write("Введите n (n > 0): ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    n = -1;
                }
            } while (n <= 0);

            int m = -1;
            do
            {
                Console.Write("Введите m (m > 0): ");
                try
                {
                    m = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    m = -1;
                }
            } while (m <= 0);

            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int index = 0;
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(input[index]) - 48;
                    index += 2;
                }
            }

            int k = -1;
            do
            {
                Console.Write("Введите k (k > 0): ");
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    k = -1;
                }
            } while (k <= 0);

            int maximPlace = 0;
            int maximIndex = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                int counter = 0;
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] == 0)
                        counter++;
                    else
                    {
                        if (counter >= maximPlace)
                        {
                            maximPlace = counter;
                            maximIndex = i;
                        }
                        counter = 0;
                    }
                }
                if (counter >= maximPlace)
                {
                    maximPlace = counter;
                    maximIndex = i;
                }
            }
            if (maximPlace < k)
                Console.WriteLine("0");
            else
                Console.WriteLine($"{maximIndex + 1}");
        }
    }
}
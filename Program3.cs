using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMPLab2
{
    internal class Program3
    {
        private static Random rnd = new Random();

        private static int[] Init()
        {
            int len;
            do
            {
                Console.Write("Введите длину массива (len > 0): ");
                try
                {
                    len = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    len = -1;
                }
            } while (len <= 0);
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(0, 100);
            return arr;
        }
        private static void Print(int[] arr)
        {
            Console.Write("Массив: ");
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        private static int[] Add(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Возможно сложение только массивов с одинаковыми рамерами!");
                return arr1;
            }
            int[] result = new int[arr1.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = arr1[i] + arr2[i];

            return result;
        }
        private static int[] Multiply(int[] arr, int num)
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for (int i = 0; i < result.Length; i++)
                result[i] = arr[i] * num;

            return result;
        }
        private static void Sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        private static string FindEquals(int[] arr1, int[] arr2)
        {
            string result = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                        result += arr1[i] + " ";
                }
            }
            if (result.Length == 0)
            {
                Console.WriteLine("Общих элементов не найдено");
                return "";
            }
            return result;
        }
        private static int Min(int[] arr)
        {
            int minim = 10000000;
            foreach (int i in arr)
            {
                if (i < minim)
                    minim = i;
            }
            return minim;
        }
        private static int Max(int[] arr)
        {
            int maxim = -10000000;
            foreach (int i in arr)
            {
                if (i > maxim)
                    maxim = i;
            }
            return maxim;
        }
        private static float Avg(int[] arr)
        {
            float sum = 0, count = 0;
            foreach (int i in arr)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }

        static void Main(string[] args)
        {
            int choice, arrSwitch = 1;
            int[] arr1 = null, arr2 = null;

            while (true)
            {
                do
                {
                    Console.WriteLine($"0) Сменить массив (сейчас {arrSwitch})");
                    Console.WriteLine("1) Инициализировать выбранный массив");
                    Console.WriteLine("2) Сложить массивы");
                    Console.WriteLine("3) Умножить массив на число");
                    Console.WriteLine("4) Найти общие значения в массивах");
                    Console.WriteLine("5) Отсортировать массив по убыванию");
                    Console.WriteLine("6) Найти минимум в массиве");
                    Console.WriteLine("7) Найти максимум в массиве");
                    Console.WriteLine("8) Найти среднее значение в массиве");
                    Console.WriteLine("9) Вывести массив");
                    Console.WriteLine("10) Выход");
                    Console.Write(">> ");
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        choice = -1;
                    }
                } while (choice < 0);

                switch (choice)
                {
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("1 - Массив 1");
                        if (arr1 == null)
                            Console.WriteLine("    Сейчас не инициализирован!");
                        Console.WriteLine("2 - Массив 1");
                        if (arr2 == null)
                            Console.WriteLine("    Сейчас не инициализирован!");
                        do
                        {
                            Console.Write(">> ");
                            try
                            {
                                arrSwitch = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                arrSwitch = -1;
                            }
                        } while (arrSwitch != 1 && arrSwitch != 2);
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine();
                        if (arrSwitch == 1)
                            arr1 = Init();
                        else if (arrSwitch == 2)
                            arr2 = Init();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        if (arr1 == null || arr2 == null)
                        {
                            Console.WriteLine("Перед началом проинициализируйте оба массива!");
                            break;
                        }
                        int[] res = Add(arr1, arr2);
                        if (res != arr1)
                            Print(res);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        if (arrSwitch == 1 && arr1 == null || arrSwitch == 2 && arr2 == null)
                        {
                            Console.WriteLine("Перед началом проинициализируйте массив!");
                            Console.WriteLine();
                            break;
                        }

                        int input = 0;
                        Console.WriteLine("Введите число на которое надо умножить массив");
                        do
                        {
                            Console.Write(">> ");
                            try
                            {
                                input = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                            }
                        } while (true);

                        if (arrSwitch == 1)
                            Print(Multiply(arr1, input));
                        else if (arrSwitch == 2)
                        {
                            Print(Multiply(arr2, input));
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        if (arr1 == null || arr2 == null)
                        {
                            Console.WriteLine("Перед началом проинициализируйте оба массива!");
                            Console.WriteLine();
                            break;
                        }
                        string resEq = FindEquals(arr1, arr2);
                        if (resEq.Length == 0)
                        {
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine($"Общие элементы: {resEq}");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        if (arrSwitch == 1)
                        {
                            if (arr1 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine("Отсортированный массив:");
                            Sort(ref arr1);
                            Print(arr1);
                        }
                        else if (arrSwitch == 2)
                        {
                            if (arr2 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine("Отсортированный массив:");
                            Sort(ref arr2);
                            Print(arr2);
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        if (arrSwitch == 1)
                        {
                            if (arr1 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine($"Минимум в массиве: {Min(arr1)}");
                        }
                        else if (arrSwitch == 2)
                        {
                            if (arr2 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine($"Минимум в массиве: {Min(arr2)}");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        if (arrSwitch == 1)
                        {
                            if (arr1 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine($"Максимум в массиве: {Max(arr1)}");
                        }
                        else if (arrSwitch == 2)
                        {
                            if (arr2 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine($"Максимум в массиве: {Max(arr2)}");
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine();
                        if (arrSwitch == 1)
                        {
                            if (arr1 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine($"Среднее значение в массиве: {Avg(arr1)}");
                        }
                        else if (arrSwitch == 2)
                        {
                            if (arr2 == null)
                            {
                                Console.WriteLine("Перед началом проинициализируйте массив!");
                                Console.WriteLine();
                                break;
                            }
                            Console.WriteLine($"Среднее значение в массиве: {Avg(arr2)}");
                        }
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine();
                        if (arrSwitch == 1)
                        {
                            if (arr1 == null)
                            {
                                Console.WriteLine("Массив не инициализирован!\n");
                                break;
                            }
                            Print(arr1);
                        }
                        else
                        {
                            if (arr2 == null)
                            {
                                Console.WriteLine("Массив не инициализирован!\n");
                                break;
                            }
                            Print(arr2);
                        }
                        Console.WriteLine();
                        break;
                    case 10:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Неизвестная команда!");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
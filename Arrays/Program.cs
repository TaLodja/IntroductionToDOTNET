//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            Console.WriteLine("Arrays");
            Console.Write("Введите размер массива: ");
            int n = 5; //Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Размер массива: {arr.Length}");
            Console.WriteLine($"Размер массива: {arr.GetLength(0)}");  //'0' - индекс измерения (актуально для многомерных массивов)
            Console.WriteLine($"Количество измерений: {arr.Rank}");

            Random rand = new Random(0); //Для того, чтобы генерировать случайные числа нужно создать объект класса 'Random'

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {arr.Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");
            //int MAX = arr[0];
            //int MIN = arr[0];
            //int summ = arr[0];
            //double average = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > MAX) MAX = arr[i];
            //    if (arr[i] < MIN) MIN = arr[i];
            //    summ += arr[i];
            //}
            //average = (double)summ / n;
            //Console.WriteLine($"MIN: {MIN}");
            //Console.WriteLine($"MAX: {MAX}");
            //Console.WriteLine($"Сумма элементов массива: {summ}");
            //Console.WriteLine($"Среднее арифметическое элементов массива: {average}");  
#endif
#if ARRAYS_2
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите элементов строки: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] i_arr_2 = new int[rows, cols];

            Random rand = new Random(0);
            Console.WriteLine($"Размер массива: {i_arr_2.Length}");
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = rand.Next(10);
                }
            }
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
            Console.WriteLine($"Максимальное значение в массиве: {i_arr_2.Cast<int>().Max()}");
            Console.WriteLine($"Минимальное значение в массиве: {i_arr_2.Cast<int>().Min()}");
#endif
#if JAGGED_ARRAYS
            int[][] arr = new int[][]
            {
                new int[]{ 3, 5, 8 },
                new int[]{ 13, 21 },
                new int[]{ 34, 55, 89 },
                new int[]{ 144, 233 }
            };

            Console.WriteLine($"Jagged Length: {arr.Length}");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int MAX = arr[0][0];
            int MIN = arr[0][0];
            int sum = 0;
            double average = 0;
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > MAX) MAX = arr[i][j];
                    if (arr[i][j] < MIN) MIN = arr[i][j];
                    sum += arr[i][j];
                    n++;
                }
            }
            average = (double)sum / n;
            Console.WriteLine($"MIN: {MIN}");
            Console.WriteLine($"MAX: {MAX}");
            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {average}");
#endif
        }
    }
}

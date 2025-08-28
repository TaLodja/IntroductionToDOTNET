//#define STRING_OPERATIONS
//#define DATA_TYPES
#define FACTORIAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if STRING_OPERATIONS
            //Console.Write("\t\t\t\tHello .NET\n");
            //Console.WriteLine("Привет");

            Console.Write("Введите Ваще имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());    //Алгоритм преобразования 'string' в 'int'

            Console.WriteLine(first_name + " " + last_name + " " + age);    //Конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));    //Форматирование строк
            Console.WriteLine($"{first_name} {last_name} {age}"); //Интерполяция строк  
#endif
#if DATA_TYPES
            bool var1 = true; ;
            Console.WriteLine($"{var1.GetType()} занимает {sizeof(bool)} Байт памяти и принимает значения в диапазоне: {bool.TrueString} - {bool.FalseString}");
            //Console.WriteLine(sizeof(bool));
            //Console.WriteLine(Boolean.);
            //Boolean var2;
            Console.WriteLine();

            char var10 = ' ';
            Console.WriteLine($"{var10.GetType()} занимает {sizeof(char)} Байт памяти");
            //Console.WriteLine(sizeof(char));
            Console.WriteLine();

            byte var=0;
            Console.WriteLine($"{var.GetType()} занимает {sizeof(byte)} Байт памяти и принимает значения в диапазоне: {byte.MinValue} ... {byte.MaxValue}");
            Console.WriteLine();
            
            sbyte var3=0;
            Console.WriteLine($"{var3.GetType()} занимает {sizeof(sbyte)} Байт памяти и принимает значения в диапазоне: {sbyte.MinValue} ... {sbyte.MaxValue}");
            Console.WriteLine();
            
            short var4=0;
            Console.WriteLine($"{var4.GetType()} занимает {sizeof(short)} Байт памяти и принимает значения в диапазоне: {short.MinValue} ... {short.MaxValue}");
            Console.WriteLine();

            ushort var5 =0;
            Console.WriteLine($"{var5.GetType()} занимает {sizeof(ushort)} Байт памяти и принимает значения в диапазоне: {ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine();
            
            int var7=0;
            Console.WriteLine($"{var7.GetType()} занимает {sizeof(int)} Байт памяти и принимает значения в диапазоне: {int.MinValue} ... {int.MaxValue}");
            Console.WriteLine();

            uint var6 =0;
            Console.WriteLine($"{var6.GetType()} занимает {sizeof(uint)} Байт памяти и принимает значения в диапазоне: {uint.MinValue} ... {uint.MaxValue}");
            Console.WriteLine();
            
            long var8=0;
            Console.WriteLine($"{var8.GetType()} занимает {sizeof(long)} Байт памяти и принимает значения в диапазоне: {long.MinValue} ... {long.MaxValue}");
            Console.WriteLine();

            ulong var9 =0;
            Console.WriteLine($"{var9.GetType()} занимает {sizeof(ulong)} Байт памяти и принимает значения в диапазоне: {ulong.MinValue} ... {ulong.MaxValue}");
            Console.WriteLine();

            float f=1;
            Console.WriteLine($"{f.GetType()} занимает {sizeof(float)} Бфйт памяти и принимает значения в диапазоне: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine();

            double d=1;
            Console.WriteLine($"{d.GetType()} занимает {sizeof(double)} Бфйт памяти и принпимает значения в диапазоне: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine();

            decimal dec=1;
            Console.WriteLine($"{dec.GetType()} занимает {sizeof(decimal)} Бфйт памяти и принпимает значения в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}");
            Console.WriteLine();
#endif
#if FACTORIAL
            Console.Write("Введите число, факториал которого треуется определить: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            double f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine($"{n}! = {f}");
#endif
        }
    }
}

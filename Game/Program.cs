using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Размеры экрана: ширина = {Console.WindowWidth}, высота = {Console.WindowHeight}.");
            Console.WriteLine("Введите начальные координаты символа: ");
            Console.Write("X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            char symbol = '+';
            ConsoleKey key;
            Console.WriteLine("Перемещайте курсор нажатием клавиш 'W', 'A', 'S', 'D' или стрелками, для выхода нажмите 'Esc'");
            do
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x--; break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x++; break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}

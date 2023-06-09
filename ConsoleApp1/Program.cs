using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в диапазоне от 1 до 100: ");
            int num = Int32.Parse(Console.ReadLine());

            if (num < 1 || num > 100)
            {
                Console.Write("Введенное число не в диапазоне от 1 до 100");
            }
            else
            {
                if (num % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                if (num % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                if (num % 5 == 1 && num % 3 == 1)
                {
                    Console.Write(num);
                }
            }

            Console.ReadLine();
        }
    }
}

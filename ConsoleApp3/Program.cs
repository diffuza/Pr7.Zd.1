using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int x = int.Parse(Console.ReadLine());
            if ((x < 100) || (x > 999)) Console.WriteLine("Вы ввели не трехзначное число!");
            else
            {
                int a = x / 100;
                int b = x / 10 % 10;
                int c = x % 10;
                int d1 = b * 100 + a * 10 + c;
                Console.WriteLine("Само число - " + x);
                Console.WriteLine("- " + d1);
                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
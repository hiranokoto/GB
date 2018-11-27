using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подсчет_колличества_цифр_числа__Удалов_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число: ");
            Console.WriteLine("Количество знаков: " + count(Console.ReadLine()));
            Console.ReadKey();
        }

        static int count(string s)
        {
            return s.Length;
        }
    }
    
}

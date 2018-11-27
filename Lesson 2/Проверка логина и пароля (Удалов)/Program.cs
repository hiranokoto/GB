using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_логина_и_пароля__Удалов_
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "root";
            string password = "GeekBrains";

            int count = 0;
            do
            {
                Console.WriteLine("\nВведите логин: ");
                string checkLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string checkPassword = Console.ReadLine();


                if (login == checkLogin && password == checkPassword)
                {

                    Console.WriteLine("Добро пожаловать");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Неверно введен логин или пароль");
                Console.ReadLine();
                ++count;
            } while (count < 3);
        }
    }
}

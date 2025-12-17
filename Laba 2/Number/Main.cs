using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    public static class Main
    {
        public static void Start()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Главное меню ===");
                Console.WriteLine("1. Дано целое число. Определить, входит ли заданная цифра в запись этого числа.");
                Console.WriteLine("2. Из заданного целого числа сформировать новое, цифры в котором идут в обратном порядке");
                Console.WriteLine("3. Определить является ли заданное целов число числом Фибоначчи.");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите пункт: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода! Введите число от 1 до 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Console.WriteLine("4. Выход из программы...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        Thread.Sleep(1000);
                        Start();
                        break;
                }

                Console.WriteLine(); // пустая строка для удобства
            }
            while (choice != 4);
        }
        private static void PressToContinue()
        {
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }
        private static void Task1()
        {
            Console.Clear();
            Console.WriteLine("1. Дано целое число. Определить, входит ли заданная цифра в запись этого числа.");
            int integer = 12345;
            int digit = 3;
            Console.WriteLine($"Целое число - {integer}, заданная цифра {digit}. {(NumberHelper.ContainsDigit(integer, digit) ? "Входит в целое число" : "Не входит в целое число")}");     
            PressToContinue();
        }
        private static void Task2()
        {
            Console.Clear();
            Console.WriteLine("2. Из заданного целого числа сформировать новое, цифры в котором идут в обратном порядке");
            int integer = 12383;
            Console.WriteLine($"Заданное число {integer}. Обратный порядок {NumberHelper.ReverseNumber(integer)}");
            PressToContinue();
        }
        private static void Task3()
        {
            Console.Clear();
            Console.WriteLine("3. Определить является ли заданное целов число числом Фибоначчи.");
            int integer = 21;
            Console.WriteLine($"Заданное число: {integer} - {(NumberHelper.IsFibonacci(integer) ? "Является число Фибоначчи" : "Не является число Фибоначчи")}");
            PressToContinue();
        }
    }
}

using System;
using System.Collections.Generic;


namespace Number
{
    public static class NumberHelper
    {
        public static bool ContainsDigit(int number, int digit)
        {
            return number.ToString().Contains(digit.ToString());
        }

        // Получить число в обратном порядке
        public static int ReverseNumber(int number)
        {
            string reversed = new string(number.ToString().Reverse().ToArray());
            return int.Parse(reversed);
        }

        // Проверка: является ли число числом Фибоначчи
        public static bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) ||
                   IsPerfectSquare(5 * number * number - 4);
        }

        private static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }
    }
}




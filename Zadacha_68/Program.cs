// Задача 68: Напишите программу реализующую метод вычисления
//  функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();

WriteLine();
WriteLine("    # Ackermann function. Recursion method. #");
WriteLine();

Write("Enter M: ");
ulong M = UInt64.Parse(ReadLine()!);

Write("Enter N: ");
ulong N = UInt64.Parse(ReadLine()!);

WriteLine(AkkermanFunc(M, N));

ulong AkkermanFunc(ulong m, ulong n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

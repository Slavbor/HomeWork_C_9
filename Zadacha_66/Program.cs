// Задача 66: Напишите программу, которая реализует рекурсивный метод
// нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;

Clear();

WriteLine();
WriteLine("    # Print summ of numbers fm M to N. Recursion method. #");
WriteLine();

Write("Enter M: ");
int M = int.Parse(ReadLine()!);

Write("Enter N: ");
int N = int.Parse(ReadLine()!);




WriteLine(SummNumbers(M, N));





int SummNumbers(int n, int m)
{
    if (n == m)
        return m;
    else if (n > m) return n + SummNumbers(n - 1, m);
    else
        return n + SummNumbers(n + 1, m);
}

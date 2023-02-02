// Задача 64: Напишите программу, которая реализует рекурсивный 
// метод вывода всех натуральных числел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;
Clear();

WriteLine();
WriteLine("    # Print numbers fm N to 1. Recursion method. #");
WriteLine();

Write("Enter N: ");
int N = int.Parse(ReadLine()!);

PrintNumbers(N);
void PrintNumbers(int num)
{
    if (num == 1)
    {
        Write(num);
    } 

    else
    {
        Write($"{num},");
        PrintNumbers(num - 1);
        
    }
}
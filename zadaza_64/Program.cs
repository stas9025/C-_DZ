﻿// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

static void Recursion(int n)
{
  if (n > 0)
  {
    Console.Write("{0} ,", n);
    Recursion(n - 1);
  }
}
Recursion(n);
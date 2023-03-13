﻿// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"



void RecurseNumber(int m, int n)
{
   if (n < m) return;
    RecurseNumber(m, n-1);
    Console.Write($"{n} ");
}

int number1 = 4;
int number2 = 10;
RecurseNumber(number1, number2);
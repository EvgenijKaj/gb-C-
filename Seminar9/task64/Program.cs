// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void RecurseNumber( int number)
{
   if (number < 1) return;
    Console.Write($"{number} ");
    RecurseNumber(number-1);
}

int myNumber = 10;
RecurseNumber( myNumber);
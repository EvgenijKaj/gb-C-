// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int m, int n)
{
    int sum = n;
    if (n < m) return 0;
    return sum + SumNumber(m, n-1);
}

int number1 = 4;
int number2 = 8;
int sum = SumNumber(number1, number2);
Console.WriteLine(sum);
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 10000 || numberA > 99999)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int numberB = numberA % 10 * 10000 + numberA % 100 / 10 * 1000 + numberA / 100 % 10 * 100 + numberA / 1000 % 10 * 10 + numberA / 10000;

//Console.WriteLine(numberB);

if (numberA == numberB)
{
    Console.WriteLine("Данное число является полиндромом");
}
else
{
    Console.WriteLine("Число не полиндром");
}
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.Write("Введите первое число: ");
string? answer1 = Console.ReadLine();
int numberA = Convert.ToInt32(answer1);

Console.Write("Введите второе число: ");
string? answer2 = Console.ReadLine();
int numberB = Convert.ToInt32(answer2);

int min = 0;
int max = 0;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    min = numberA;
    max = numberB;
}

Console.Write("max = ");
Console.WriteLine(max); 
Console.Write("min = ");
Console.WriteLine(min);
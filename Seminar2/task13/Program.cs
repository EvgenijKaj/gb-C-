// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb < 100 )
{
    Console.WriteLine("Третьей цифры нет");
}

else 
{
    while (numb > 999)
    {
        numb = numb/10;
    }
    int res = numb % 10;
    Console.WriteLine($"Третья цифра числа равна {res}");
}
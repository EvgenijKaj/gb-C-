// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string? answeruser = Console.ReadLine();
int numb = Convert.ToInt32(answeruser);

Console.WriteLine("Вывод чётных чисел от 1 до "+ numb);
for ( int i = 2; i <= numb; i = i+2)
{
        Console.WriteLine(i);
}

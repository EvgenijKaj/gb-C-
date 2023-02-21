//Таблица кубов числа N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (double i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
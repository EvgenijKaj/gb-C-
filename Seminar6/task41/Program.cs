


Console.Write("Введите число или stop : ");
string str = Console.ReadLine();
int count = 0;
while (str != "stop")
{
    int number = Convert.ToInt32(str);
    if (number > 0) count++;
    Console.Write("Введите число или stop : ");
    str = Console.ReadLine();
}
Console.WriteLine($"Количество положительных чисел = {count}");



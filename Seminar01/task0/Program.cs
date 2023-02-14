
Console.WriteLine("Введите первое число: ");
string? answer1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? answer2 = Console.ReadLine();
int number1 = Convert.ToInt32(answer1);
int number2 = Convert.ToInt32(answer2);
if (number1 == number2*number2)
{
    Console.WriteLine("Да, Первое число является квадратом второго");    
}
else 
{
    Console.WriteLine("Нет, Первое число НЕ является квадратом второго");
}
    
//по номеру четверти определить возможные координаты точек
Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());


if (number == 1)
{
    Console.WriteLine("Возможные значения кординат x > 0, y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Возможные значения кординат x < 0, y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Возможные значения кординат x < 0, y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Возможные значения кординат x > 0, y < 0");
}
else 
{
    Console.WriteLine("Невозможно определить значения координат");
}
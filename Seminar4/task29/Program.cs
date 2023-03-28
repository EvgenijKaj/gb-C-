// Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

Console.Write("[");
for (int i = 0; i < 7; i++)
{
    array[i] = Random.Shared.Next(100);
    Console.Write($"{array[i]}, ");
}

array[7] = Random.Shared.Next(100);
Console.Write($"{array[7]}");
Console.Write("]");
    
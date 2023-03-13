﻿// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив

// Домашняя работа
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



//номер четверти по координатам точек
// int ReadNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x = ReadNumber("Введите кординату точки по X");
// int y = ReadNumber("Введите кординату точки по X");

// Console.WriteLine(
//     x > 0 && y > 0 ? "Точка находится в первой координатной четверти":
//     x < 0 && y > 0 ? "Точка находится во второй координатной четверти":
//     x < 0 && y < 0 ? "Точка находится в третьей координатной четверти":
//     x > 0 && y < 0 ? "Точка находится в четвёртой координатной четверти":
//     "Невозможно определить координатную четверть"
// );
Console.WriteLine("Введите кординату точки по X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату точки по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой координатной четверти");
}
else 
{
    Console.WriteLine("Невозможно определить координатную четверть");
}
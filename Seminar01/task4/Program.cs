﻿// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int n1 = 22;
int n2 = 5;
int n3 = 78;

int max = n1;

if ( n2 > max ) 
{ 
    max = n2;
};

if ( n3 > max ) 
{ 
    max = n3;
};

Console.WriteLine(max);
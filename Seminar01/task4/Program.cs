﻿// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int n1 = 22;
int n2 = 5;
int n3 = 78;

int max = 0;

if ( n1 > max ) 
{ 
    max = n1;
};

if ( n2 > max ) 
{ 
    max = n1;
};

if ( n3 > max ) 
{ 
    max = n1;
};

Console.WriteLine(max);
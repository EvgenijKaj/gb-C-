// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DegreeNumber(int baseNumber, int degree)
{
    if(degree == 0) return 1;
    return baseNumber*DegreeNumber(baseNumber, degree - 1);
}

int number = 2;
int degree = 6;
int res = DegreeNumber(number, degree);
Console.WriteLine(res);
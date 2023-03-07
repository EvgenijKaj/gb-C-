// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

(double, double) InterPoint(double a, double c, double b, double d)
{
    double x = (d-c)/(a-b);
    double y = a*(d-c)/(a-b)+c;
    return( x , y);
}

double k1 = 2;
double b1 = -1;
double k2 = -3;
double b2 = 1;
(double x, double y) = InterPoint(k1, b1, k2, b2);

Console.WriteLine($"Координаты точки пересечения ( {x:f2}; {y:f2})");
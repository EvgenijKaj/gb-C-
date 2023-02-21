// По координатам двух точек определить расстояние между ними
double ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = ReadNumber("Введите кординату первой точки по X");
double y1 = ReadNumber("Введите кординату первой точки по Y");
double z1 = ReadNumber("Введите кординату первой точки по Z");

double x2 = ReadNumber("Введите кординату второй точки по X");
double y2 = ReadNumber("Введите кординату второй точки по Y");
double z2 = ReadNumber("Введите кординату второй точки по Z");

double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между точками равно {dist:f2}");
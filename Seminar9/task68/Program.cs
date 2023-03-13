// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int numberM = 3;
int numberN = 5;

Console.Write(funcAkkerman(numberM, numberN));

int funcAkkerman(int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0 && m > 0) return funcAkkerman(m-1, 1);
    if (m > 0 && n > 0) return funcAkkerman(m-1, funcAkkerman(m, n-1));
    return 1;
}
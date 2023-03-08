// Задача 50: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] matrix = {
    {1, 3, 5},
    {4, 5, 7},
    {-1, -5, -9}
};

bool ConteinElement(int[,] matrix, int mRow, int nColum)
{
    if (mRow >= matrix.GetLength(0) || nColum >= matrix.GetLength(1))
    {
       return false;
    }
    else
    {
       return true;
    }
}

int mRowUser = ReadNumber("Введите индекс строки");
int nColumUser = ReadNumber("Введите индекс столбца");
if (ConteinElement(matrix, mRowUser, nColumUser) == true)
{
    Console.WriteLine($"Знаение элемента на позиции ({mRowUser}, {nColumUser}) = {matrix[mRowUser, nColumUser]}");
}
else
{
    Console.WriteLine("Такого элемента нет");
}

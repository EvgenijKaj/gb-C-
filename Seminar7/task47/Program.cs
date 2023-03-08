// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

//Задача 46. Создание двумерного массива, заполненного случайнми числами.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] GetRandomMatrix(int rows, int colums)
{
    double[,] matrix = new double[rows, colums];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble() * 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
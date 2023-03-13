// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int colums, int leftBorder = 0, int rightBorder = 10)
{
    int[,] matrix = new int[rows, colums];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArrangeMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int k = matrix.GetLength(1)-1; k > 0; k--)
        {
            int temp = matrix[i, k];
            for(int j = k-1; j >= 0; j--)
            {
                if(matrix[i, j] > temp)
                {
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = temp; 
                    temp = matrix[i, k];
                }
            }
        }
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
ArrangeMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
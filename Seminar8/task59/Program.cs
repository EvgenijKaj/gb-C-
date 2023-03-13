// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

(int, int) MinElementMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int imin = 0;
    int jmin = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                imin = i;
                jmin = j;
            }
        }
    }
    return (imin, jmin);
}

int[,] DeleteRowAndColumMinElement(int[,] matrix)
{
    (int iMin, int jMin) = MinElementMatrix(matrix);
    Console.WriteLine($"минимальный элемент {matrix[iMin, jMin]} с индексами {iMin},{jMin}");
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for(int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for(int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            if (i >= iMin && j < jMin)
            {
                newMatrix[i, j] = matrix[i+1, j];
            }
            else if (i >= iMin && j >= jMin)
            {
                newMatrix[i, j] = matrix[i+1, j+1];
            }
            else if (i < iMin && j >= jMin)
            {
                newMatrix[i, j] = matrix[i, j+1];
            }
            else
            newMatrix[i, j] = matrix[i, j];
        }
    }
    return newMatrix;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
int[,] newMyMatrix = DeleteRowAndColumMinElement(myMatrix);
Console.WriteLine();
PrintMatrix(newMyMatrix);
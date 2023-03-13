// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

void PrintRepeats(int[,] matrix)
{
    int[] repeats = new int[10];
     
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = matrix[i, j];
            repeats[matrix[i, j]]++;
        }
    }

    for(int i = 0; i < repeats.Length; i++)
        {
            if (repeats[i] != 0)
            Console.WriteLine($"{i} повторяется {repeats[i]} раз");
        }
}




int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
PrintRepeats(myMatrix);


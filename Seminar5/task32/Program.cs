// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] arrayMinus(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int lengthArray = ReadNumber("Задайте длину массива");
int leftRange = ReadNumber("Введите левую границу значений массива");
int rightRange = ReadNumber("Введите правую границу значений массива");

int[] myArray = GetRandomArray(lengthArray, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
arrayMinus(myArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");


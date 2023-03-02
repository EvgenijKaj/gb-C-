// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int CountEvenNamber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int lengthArray = 10;
int[] UseArray = GetRandomArray(lengthArray);
Console.WriteLine($"[{string.Join(',', UseArray)}]");
int count = CountEvenNamber(UseArray);
Console.WriteLine(count);
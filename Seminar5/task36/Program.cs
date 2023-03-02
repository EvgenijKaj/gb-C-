// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 100);
    }
    return array;
}

int SumElementsOddPosition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return(sum);
}

int LengthArray = ReadNumber("Задайте длину массива");
int[] UseArray = GetRandomArray(LengthArray);
Console.WriteLine($"[{string.Join(',', UseArray)}]");
int SumElem = SumElementsOddPosition(UseArray);
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {SumElem}");
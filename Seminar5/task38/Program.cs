// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] GetRandomArray(int length)
{
    double[] array = new double[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(Random.Shared.NextDouble(), 2);
    }
    return array;
}

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    } 
    double diffrence = max - min;
    return diffrence;
}

double[] MyArray = GetRandomArray(10);
Console.WriteLine($"[{string.Join('|', MyArray)}]");
double diffrenceMaxandMin = DiffMaxMin(MyArray);
Console.WriteLine(diffrenceMaxandMin);
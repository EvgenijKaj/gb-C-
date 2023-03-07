// Задача 44: Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


int[] Fibonach( int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 0; i < array.Length-2; i++)
    {
        array[i+2] = array[i] + array[i+1];
    }
    return array;
}

int num = 11;
int[] MyArray = Fibonach(num);
Console.WriteLine(string.Join(' ', MyArray));
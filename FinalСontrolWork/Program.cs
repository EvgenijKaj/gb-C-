//Задача. Составить из имеющегося массива строк, массив со строками не более 3-ч символов.

string[] GetRandomArray(int length)
{
    string[] array = new string[length];

    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {i} элемента массива");
        array[i] = Conole.ReadLine();
    }
    return array;
}
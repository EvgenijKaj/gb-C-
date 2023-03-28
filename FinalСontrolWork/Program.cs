//Задача. Составить из имеющегося массива строк, массив со строками не более 3-х символов.

string[] GetConsoleArray(int length)
{
    string[] array = new string[length];

    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {i} элемента массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

void NewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($" {array[i]} ");
        }
    }
    Console.Write("]");
}



int lengthArray = 5;
string[] myArray = GetConsoleArray(lengthArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
NewArray(myArray);


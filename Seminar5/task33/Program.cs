// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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


// string Prov(int number, int[] array)
// {
//     int count = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             count +=1;
//         }
//     }
//     if (count > 0)
//     {
//        string answer = "Массив содержит данное число";
//         return answer;
//     }
//     else
//     {
//          string answer = "Данного числа нет в массиве";
//         return answer;
//     }
// }

bool ElementInArray(int[] array, int number)
{
    bool result = false;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
}


int lengthArray = ReadNumber("Задайте длину массива");
int leftRange = ReadNumber("Введите левую границу значений массива");
int rightRange = ReadNumber("Введите правую границу значений массива");

int[] myArray = GetRandomArray(lengthArray, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");

int myNumber = ReadNumber("Задайте число");

bool res = ElementInArray(myArray, myNumber);
Console.WriteLine(res);
// string myAnswer = Prov(myNumber, myArray);
// Console.WriteLine(myAnswer);


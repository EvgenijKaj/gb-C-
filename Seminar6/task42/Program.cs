// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

// int[] GetRandomArray(int length, int leftRange, int rightRange)
// {
//     int[] array = new int[length];

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// int[] TenInTwo(int n)
// {
//     int i = 0;
//     int m = n;
//     while (n > 0 )
//     {
//         //array[i] = n % 2;
//         i++;
//         n = n/2;
//     }
//     int[] array = new int[i];
//     for(int j = 0; j < i; j++)
//     {
//         array[array.Length - j - 1] = m % 2;
//         m /= 2;
//     }
//     return array;
// }

string TenInTwo(int n)
{
    string res = "";
    for (; n > 0; n /= 2)
    {
        res = Convert.ToString(n % 2) + res;
    }
    return res;
}

int x = 44;
string Res = TenInTwo(x);
Console.WriteLine(Res);
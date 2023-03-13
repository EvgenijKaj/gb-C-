// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigit(int number)
{
    int sum = 0;
    sum = number%10;
    if(number/10 > 0) 
    {
        return sum = number%10 + SumDigit(number/10);
    }
    return sum;
}

int myNamber = 11534;
int resultSum = SumDigit(myNamber);
Console.WriteLine(resultSum);
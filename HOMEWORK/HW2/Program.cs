// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int GetSecondDigit(int num)
{
    int res = (num / 10) % 10;
    return res;
}
Console.Write("Please input three digit number N = ");
int numN = Convert.ToInt32(Console.ReadLine());
int result = GetSecondDigit(numN);
Console.WriteLine($"Second digit of {numN} -> {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int GetThirdDigit(int num)
{
    int var = num;   
    int digits = 0;
    while (var > 0 )
    {
        digits++;
                                   
        if ((var / 1000 == 0) && (var / 100 != 0 )) //укороченное число является трехзначным
        {
            int res = var % 10;                     //возвращаем младший разряд
            return res ;
        }
        var = var / 10;                             //укорачивание числа с младших разрядов
    }
    return -1;
}
Console.Write("Please input number N = ");
int numN = Convert.ToInt32(Console.ReadLine());
int result = GetThirdDigit(numN);
if (result == -1) 
{
    Console.WriteLine($"Number {numN} has no third digit");
}
else Console.WriteLine($"Third digit of {numN} -> {result}");
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
bool IsWeekend(int num)
{
    if ((num == 6)||(num == 7)) return true;
    else return false;
}
Console.Write("Please enter day of the week = ");
int day = Convert.ToInt32(Console.ReadLine());
bool result = IsWeekend(day);
Console.WriteLine($"Day of the week is weekend -> {result}");
*/
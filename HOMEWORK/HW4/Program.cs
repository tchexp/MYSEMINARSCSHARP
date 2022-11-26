// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PowerOf(int num, int exp)
// { int result = 1;
//     for (int i = 0; i < exp; i++)
//     {
//         result = result * num;
//     }
//     return result;
// }

// Console.Write("Please enter base A = ");
// int baseNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter exponent B = ");
// int exponentNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"A EXP(B) = {PowerOf(baseNumber, exponentNumber)} ");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigits (int num)
// {
//     int count = 0;
//     int buffer = num;
//     int result = 0;
//     while (buffer > 0 )
//     {
//         result = result + buffer % 10;
//         buffer = buffer / 10;
//         count++;
//     }
//     return result;
// }

//  Console.Write("Please enter number N = ");
//  int number = Convert.ToInt32(Console.ReadLine());
//  Console.Write($"sum of digits of {number} -> {SumDigits(number)} ");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArrayRandom(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Result array");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine();
}

Console.Write("Please input array size = ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input element MIN value = ");
int arrMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array MAX value = ");
int arrMaxValue = Convert.ToInt32(Console.ReadLine());
ShowArray(FillArrayRandom(arrSize, arrMinValue, arrMaxValue));
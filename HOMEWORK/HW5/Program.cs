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

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int CountEven(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) count ++;
//     }
//     return count;
// }

// Console.Write("Please input number of array elements -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayRandom(size, 100, 999);
// ShowArray(array);
// Console.WriteLine($"Number of even elements of the array -> {CountEven(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int SummOddPos(int[] arr)
// {
//     int result = 0;
//     for (int i = 1; i < arr.Length; i += 2)
//     {
//         result = result + arr[i];
//     }
//     return result;
// }

// Console.Write("Please input array size -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array element min value -> ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array element max value -> ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayRandom(size, min, max);
// ShowArray(array);
// Console.WriteLine($"Number of elements on odd positins -> {SummOddPos(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int FindRange (int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];        
    }
    return max - min;
}

//int[] array = {3, 7, 22, 2, 78};
Console.Write("Please input array size -> ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element min value -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element max value -> ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(size, min, max);
ShowArray(array);
Console.WriteLine($"Range from max to min in array -> {FindRange(array)}");
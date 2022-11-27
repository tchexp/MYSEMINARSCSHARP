//задача задать массив из 9 элементов и посчитать сумму отрицательных и положительных элементов

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

// int SumPositive(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sum = sum + array[i];
//     }
//     return sum;
// }

// int SumNegative(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) sum = sum + array[i];
//     }
//     return sum;
// }

// int[] InvertArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         //array[i] = array[i] * -1;
//         array[i] *= -1;
//     }
//     return array;
// }

//задача определить присутствует ли заданное число в массива
bool IsPresent (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}
//задача найдите количество элементов массива которые лежат в отрезке

int CountInRange(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end) count ++;
    }
    return count;
}

Console.Write("Please input array size -> ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element min value -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element max value -> ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArrayRandom(size, min, max);
ShowArray(arr);
// Console.Write("Please enter number for search = ");
// int serchNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Sum of positive elements -> {SumPositive(arr)} \nSum of negative elements -> {SumNegative(arr)}");
//ShowArray(InvertArray(arr));
//Console.WriteLine($"Is number {serchNum} present in array? -> {IsPresent(arr, serchNum)}");
//Console.WriteLine("string 1 \nstring2");
Console.Write("Please enter number FROM = ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter number TO = ");
int to = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"there are {CountInRange(arr, from, to)} elements in range from {from} to {to}");

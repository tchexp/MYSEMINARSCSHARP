// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    Console.WriteLine("Result array");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinSumRow(int[,] array)
{   
    int minRow = 0;
    int minSum = 0;
    for (int k = 0; k < array.GetLength(1); k++)//сумма элементов в первой строке
    {
        minSum = minSum + array[0,k];
    }
    for (int i = 1; i < array.GetLength(0); i++)//поиск минимальной суммы элементов в последующих строках
    {   
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (sum < minSum) 
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}

Console.Write("Please input array number of rows -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array number of columns -> ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element min value -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element max value -> ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(min,max,rows,columns);
Show2DArray(myArray);
Console.WriteLine($"Smallest sum row index -> {FindMinSumRow(myArray)}");
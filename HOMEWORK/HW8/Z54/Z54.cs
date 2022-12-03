// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SelectinSort2DDesc(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temp;

        }
    }
}

Console.Write("Please input array number of rows -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array number of columns -> ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element min value -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array element max value -> ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(min, max, rows, columns);
Show2DArray(myArray);
SelectinSort2DDesc(myArray);
Show2DArray(myArray);
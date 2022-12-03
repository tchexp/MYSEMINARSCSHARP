﻿// // Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// double[,] Create2DRealRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     double[,] newArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//         }
//     }
//     return newArray;
// }

// // void Show2DArray(double[,] array)
// // {
// //     Console.WriteLine("Result array");
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             Console.Write($"{Math.Round(array[i,j],2)}; ");
// //         }
// //         Console.WriteLine();
// //     }
// //     Console.WriteLine();
// // }

// // Console.Write("Please input array number of rows -> ");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input array number of columns -> ");
// // int columns = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input array element min value -> ");
// // int min = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input array element max value -> ");
// // int max = Convert.ToInt32(Console.ReadLine());
// // double[,] myArray = Create2DRealRandomArray(min,max,rows,columns);
// // Show2DArray(myArray);


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет


// // int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// // {
// //     int[,] newArray = new int[rows, columns];
// //     for (int i = 0; i < rows; i++)
// //     {
// //         for (int j = 0; j < columns; j++)
// //         {
// //             newArray[i,j] = new Random().Next(minValue, maxValue + 1);
// //         }
// //     }
// //     return newArray;
// // }

// // void Show2DArray(int[,] array)
// // {
// //     Console.WriteLine("Result array");
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             Console.Write($"{array[i,j]}; ");
// //         }
// //         Console.WriteLine();
// //     }
// //     Console.WriteLine();
// // }

// void GetElement(int[,] arr, int rowIdx, int columnIdx)
// {
//     if (rowIdx > arr.GetLength(0) || columnIdx > arr.GetLength(1))
//         Console.WriteLine($"Element [{rowIdx}, {columnIdx}] does not exit");
//     else Console.WriteLine(arr[rowIdx, columnIdx]);
// }


// // Console.Write("Please input array number of rows -> ");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input array number of columns -> ");
// // int columns = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input array element min value -> ");
// // int min = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input array element max value -> ");
// // int max = Convert.ToInt32(Console.ReadLine());
// // int[,] myArray = Create2DRandomArray(min,max,rows,columns);
// // Show2DArray(myArray);
// // Console.Write("Please input element row index -> ");
// // int row = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Please input element column index -> ");
// // int column = Convert.ToInt32(Console.ReadLine());
// // Console.Write($"Element with index [{row}, {column}] -> ");
// // GetElement(myArray, row, column);



// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     Console.WriteLine("Result array");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}; ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SumColumn(int[,] arr)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         double sum = 0;
//         int i = 0;
//         while (i < arr.GetLength(0))
//         {
//             sum = sum + arr[i,j];
//             i++;
//         }
//         Console.Write($"{Math.Round(sum / i, 2)}; ");
//     }
//     Console.WriteLine();
// }


// Console.Write("Please input array number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array element min value -> ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array element max value -> ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(min, max, rows, columns);
// Show2DArray(myArray);
// SumColumn(myArray);

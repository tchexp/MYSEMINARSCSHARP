// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Show2DArray(int[,] array)
{
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

int[,] MultiplyMatrices(int[,] arrA, int[,] arrB)
{
    int[,] zeroMatrix = new int[1, 1] {{ 0 }};
    if (arrA.GetLength(1) != arrB.GetLength(0))  //number of columns in the first matrix must be equal to the number of rows in the second matrix
    {
        Console.WriteLine("Multiplication is not possible for entered matrices");
        return zeroMatrix;
    }
    else
    {
        int m = arrA.GetLength(0);
        int n = arrA.GetLength(1);
        int p = arrB.GetLength(1);
        int[,] arrResult = new int[m, p];//
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    arrResult[i,j] = arrResult[i,j] + arrA[i,k] * arrB[k,j];
                }
            }
        }
        return arrResult;
    }
}

// int[,] arrayA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//int[,] arrayB = new int[3, 2] { { 10, 11 }, { 20, 21 }, { 30, 31 } };
int[,] arrayA = new int[2, 2]  {{2, 4}, {3, 2}};
int[,] arrayB = new int[2, 2]  {{3, 2}, {3, 3}};
Console.WriteLine("Matrix A");
Show2DArray(arrayA);
Console.WriteLine("Matrix B");
Show2DArray(arrayB);
int[,] arrayResult = MultiplyMatrices(arrayA, arrayB);
Console.WriteLine("Matrix sum");
Show2DArray(arrayResult);

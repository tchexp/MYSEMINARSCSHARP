// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

void FillArraySpiral(int[,] array)
{
    int filler = 1;
    int i = 0;
    int j = -1;//вход в массив "снаружи"
    string direction = "RIGHT";
    while (true)
    {
        if (
        (j + 1 == array.GetLength(1) || array[i, j + 1] != 0)
     && (i + 1 == array.GetLength(0) || array[i + 1, j] != 0)
     && (j - 1 < 0 || array[i, j - 1] != 0)
     && (i - 1 < 0 || array[i - 1, j] != 0)
    ) break;

        if (direction == "RIGHT")
        {
            if (j + 1 == array.GetLength(1) || array[i, j + 1] != 0) direction = "DOWN";
            else j++;
        }
        if (direction == "DOWN")
        {
            if (i + 1 == array.GetLength(0) || array[i + 1, j] != 0) direction = "LEFT";
            else i++;
        }
        if (direction == "LEFT")
        {
            if (j - 1 < 0 || array[i, j - 1] != 0) direction = "UP";
            else j--;
        }
        if (direction == "UP")
        {
            if (i - 1 < 0 || array[i - 1, j] != 0) direction = "RIGHT";
            else i--;
        }
        //array[i, j] = new Random().Next(1, 9 + 1);
        array[i, j] = filler;    
        filler ++;

        Console.Clear();
        Show2DArray(array);
        //Console.WriteLine($"{direction} [{i}, {j}], {array[0, 1]}");
        Thread.Sleep(300);
    }

}


int[,] myArray = new int[4, 6];
FillArraySpiral(myArray);
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

// Console.Write("Please input array number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array element min value -> ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array element max value -> ");
// int max = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(min,max,rows,columns));


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
int[,] CreateNewArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;
        }
        
    }
    return newArray;
}
// Console.Write("Please input array number of rows -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array number of columns -> ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Show2DArray(CreateNewArray(rows,columns));

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

int[,] Create2DArray (int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j]= i+j;
        }
    }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SquareGarden(int[,]array)

{
     for (int i = 0; i < array.GetLength(0) ; i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0  && j %2 == 0)
            array[i,j] = array[i,j]* array[i,j];
        }
    }
    return array;
}
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = (Create2DArray(rows,columns));
Show2DArray(array);
Show2DArray(SquareGarden(array));

//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


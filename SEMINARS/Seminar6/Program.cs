

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


//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j ; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] arr = FillArrayRandom(5, 0, 25);
//ShowArray(arr);
//ShowArray(ReverseArray(arr));

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool CheckTriangle(int a, int b, int c)
{
    if ((a+b>c) && (b+c>a) && (c+a)>b) return true;
    return false;

}
//Console.WriteLine(CheckTriangle(10,20,30));

int InputNumber()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x <= 0) return InputNumber();
    else return x;
}
Console.WriteLine(CheckTriangle(InputNumber(),InputNumber(),InputNumber()));

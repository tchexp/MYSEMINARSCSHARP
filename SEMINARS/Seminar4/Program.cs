//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum (int num)
// {
//     int sum = 0;
//     for (int i = 1; i <=  num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.Write("Please input number A = ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Summ all = {FindSum (number)}");


//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// int CountDigits(int num) //Вспомогоательный метод счтечик цифр в числе
// {
//     return Convert.ToInt32(Math.Floor(Math.Log10(num) + 1));
// }

// Console.Write("Please input number A = ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Number = {CountDigits(number)}");


//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]


// int[] FillArrayRandom(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Result array");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Please input array size = ");
// int arrSize = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array size = ");
// int ArrMinValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input array size = ");
// int arrMaxValue = Convert.ToInt32(Console.ReadLine());


// // int[] myArray = FillArrayRandom(arrSize, ArrMinValue, arrMaxValue);
// // ShowArray(myArray);
// ShowArray(FillArrayRandom(arrSize, ArrMinValue, arrMaxValue));

//Console.WriteLine((! (1 == 1)).GetType());

Console.WriteLine(123 % 10);
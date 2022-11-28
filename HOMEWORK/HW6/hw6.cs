// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Result array");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.WriteLine();
// }

// int[] InputNumbers() //последовательный ввод чисел
// {
//     List<int> numbers = new List<int>();
//     while (true)
//     {
//         Console.Clear();
//         Console.WriteLine("Please input number, to exit press Enter in empty string");
//         string input = Console.ReadLine();
//         if (string.IsNullOrEmpty(input)) { break; }
//         numbers.Add(int.Parse(input));
//     }
//     return numbers.ToArray();
// }

// int CountPositive(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result++;
//     }
//     return result;
// }

// int[] arr = InputNumbers();
// int count = CountPositive(arr);
// ShowArray(arr);
// Console.WriteLine($" Number of elements > 0  -> {count}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, 
//                     y = k2 * x + b2; 

//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// string FindIntersection(int b1, int k1, int b2, int k2)
// {
//     float tan = k2 - k1;
//     if (tan == 0) return ("Lines are parallel, no solution");
//     float x = (b1 - b2) / tan;
//     float y = (k2 * b1 - k1 * b2) / tan;

//     return ($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");
// }

// Console.Write("Please input k1 -> ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input b1 -> ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input k1 -> ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input b1 -> ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// string output = FindIntersection(k1, b1, k2, b2);
// Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> {output}");
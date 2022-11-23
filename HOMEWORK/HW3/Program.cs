// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int CountDigits(int num) //Вспомогоательный метод счтечик цифр в числе
// {
//     return Convert.ToInt32(Math.Floor(Math.Log10(num) + 1));
// }

// bool IsPalindrome(int num)  //проверяет любое число - является ли оно палиндромом
// {   
//     int number = num;
//     int length = CountDigits(num);
//     for (int i = 0; i < length / 2; i++)
//     {
//         int firstDgt = number / Convert.ToInt32(Math.Pow(10,CountDigits(number)-1)); //первая цифра числа
//         int lastDgt = number % 10;                                                   //последняя цифра числа
//         if (firstDgt != lastDgt) return false;
//         number = number % Convert.ToInt32(Math.Pow(10,CountDigits(number)-1)) / 10; //"обрезали" число с двух концов
//     }
//     return true;
// }

// int number = 0;
// while (number != 99925)
// {
//     Console.Write ("Please enter N = ");
//     number = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Number {number} is palindrome -> {IsPalindrome(number)}");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double distance = Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)
//                                    +Math.Pow(y1-y2,2)
//                                    +Math.Pow(z1-z2,2)    
//                                   ),2
//                          );
//     return distance;
// }

// Console.Write ("Please enter x of point A ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Please enter y of point A ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Please enter z of point A ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Please enter x of point B ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Please enter y of point B ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Please enter z of point B ");
// int zB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Distance between A({xA}, {yA}, {zA}) and B({xB}, {yB}, {zB}) is -> { GetDistance(xA,yA,zA,xB,yB,zB)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void GetCubes(int num)
// {
//     Console.Write ($"Cubes of {num} -> 1 ");
//     for (int i = 2; i <= num; i++)
//     {
//         Console.Write ($", {Math.Pow(i,3)}");
//     }
// }

// Console.Write ("Please enter number N = ");
// int number = Convert.ToInt32(Console.ReadLine());
// GetCubes(number);
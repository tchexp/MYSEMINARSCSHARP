// //Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// //четверти (x и y).

// int FindQuart(double x, double y)
// {
//     if ((x > 0)&&(y > 0 )) return 1;
//     if ((x < 0)&&(y > 0 )) return 2;
//     if ((x < 0)&&(y < 0 )) return 3;
//     if ((x > 0)&&(y < 0 )) return 4;
//     return 0;
// }

// Console.Write ("Введите число x = ");
// int x = Convert.ToDouble(Console.ReadLine());
// // Console.Write ("Введите координату y = ");
// // double y = Convert.ToDouble(Console.ReadLine());
// // int result = FindQuart(x, y);
// // Console.WriteLine($"The quarter number of our point {result}");


// //Задача 2.Напишите программу, которая по заданному номеру четверти, 
// //показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindCoordinates(int quart)
// {
//     if ((quart < 1)||(quart > 4)) Console.WriteLine("Non existent quarter");
//     if (quart == 1) Console.WriteLine("Range of x - positive, range of y - positive");
//     if (quart == 2) Console.WriteLine("Range of x - negative, range of y - positive");
//     if (quart == 3) Console.WriteLine("Range of x - negative, range of y - negative");
//     if (quart == 4) Console.WriteLine("Range of x - positive, range of y - negative");            
// }
// /*
// Console.Write ("Input quart = ");
// int x = Convert.ToInt32(Console.ReadLine());
// FindCoordinates(quart: x);
// */

// //Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// //A (3,6); B (2,1) -> 5,09
// //A (7,-5); B (1,-1) -> 7,21
// //взять квадратный корень из суммы квадратов разности его координат

// double GetLength(double x1, double y1, double x2, double y2)
// {
//     double l = Math.Sqrt()
// }

// for (int i = 0; i < length; i++)
// {
    
// }

// //Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N


void SqrOl(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(i * i);
    }
}
SqrOl(5);

Console.Write ("Введите число N = ");
int x = Convert.ToDouble(Console.ReadLine());
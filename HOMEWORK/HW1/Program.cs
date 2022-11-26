//Выполнил Захаров Николай

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("Please input number a = ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number b = ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)   Console.Write($" -> max = {numA}       a > b");
if (numA < numB)   Console.Write($" -> max = {numB}       b > a");
if (numA == numB)  Console.Write($" -> max = {numB}       a = b");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Please input number a = ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number b = ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number c = ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
if (numB > max)   max = numB;
if (numC > max)   max = numC;
Console.WriteLine($"max number from {numA}; {numB}; {numC}; -> {max}");




//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.Write("Please input number ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN % 2 == 0)   Console.Write($"Number {numN} is Even ");
else Console.Write($"Number {numN} is Odd ");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Please input number N = ");
int numN = Convert.ToInt32(Console.ReadLine());
int cnt = 2;
while (cnt <= numN) 
{
    Console.Write($"{cnt}; ");
    cnt = cnt + 2;
}




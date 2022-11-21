//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
/*
int FindBiggestDigit (int num)
{
int ed = num % 10;
int dec = num / 10;
if (ed > dec) return ed;
else return dec;
}

int random = new Random().Next(10,100);
int result = FindBiggestDigit(random);
Console.WriteLine($" Random number {random} has bigest digit {result}");
*/

//2 Задача.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98
/*
int CutNumber (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int res = sot * 10 + ed;
    return res;
}
int random = new Random().Next(100,1000);
int result = CutNumber(random);
Console.WriteLine($" Result of circumsize of {random} will be {result}");
*/

//Задача 3.Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

void IsDiv (int num)
{

}



//4 Задача.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14  ->  нет
46  ->  нет
161 ->  да



bool IsDiv (int num1)
{
    if (( num1 % 7 == 0 ) && ( num1 % 23 == 0 ))

    {
        return true;
    
    }
     else
    {
      return false;
    }
}
int A = 162;
bool B =IsDiv (A);

Console.WriteLine(B);


//int CutNumber (int num) 
//{
   // int ed = num % 10;
   // int sot = num / 100;
    //
   // int res = sot * 10 + ed;
//    return res;
//}

//int random = new Random().Next(100,1000);
//int newNumber = CutNumber(random);
//Console.WriteLine($"New version of {random} is {newNumber}");/
// void IsDiv (int num1, int num2)
// {

//     if (num2 % num1 == 0)
//     {
//         Console.WriteLine ($"number {num2} {num1} -> devisble");
    
//     }
//     else 

//     {
//        Console.WriteLine ($"number {num2} {num1} ->not devisble {num2 % num1}");
//     }
// }
// int A = 5;
// int B = 35;
// IsDiv (A, B);
// int random = new Random().Next(100,1000);
// int newNumber = CutNumber(random);
// Console.WriteLine($"New version of {random} is {newNumber}");/

// //Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// //N = 5 -> "1, 2, 3, 4, 5"
// //N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers(int n)
// {
//     if (n >= 1)
//     {
//         ShowNumbers(n - 1);
//         Console.Write(n + " ");

//     }
// }

// //ShowNumbers(5);


// if (5 >= 1)
// {
//     if (4 >= 1)
//     {
//         if (3 >= 1)
//         {
//             if (2 >= 1)
//             {
//                 if (1 >= 1)
//                 {

//                     Console.Write(5 + " ");

//                 }
//                 Console.Write(4 + " ");

//             }
//             Console.Write(3 + " ");

//         }
//         Console.Write(4 + " ");

//     };
//     Console.Write(5 + " ");

// }


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
// int FindSum(int num)
// {
//     if (num != 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine(FindSum(-123));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"

// void NaturaleNum (int m, int n)
// {
//    if(n != m)
//    {
//     if(n > m)     
//     {
//         NaturaleNum(m,n -1);
//         Console.Write(n +  " * ");
//     }
//     else 
//     {
//         NaturaleNum(m -1, n);
//         Console.Write(m +  " * ");
//     }
//    }
//    else Console.Write(m + " * ");
// }

// NaturaleNum(5,10);


//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
//целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

// int FindPowr (int a, int b)
// {
//    if(b == 0)
//    return 1;
//    else 
//    {
//      return FindPowr(a, b - 1 ) * a;
//    } 
// }
// int sum = FindPowr(2,3);
// Console.WriteLine(sum);

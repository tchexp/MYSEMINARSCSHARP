
/*Console.WriteLine("Please input number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);*/


/*Console.WriteLine("Please input number");
int num = Convert.ToInt32(Console.ReadLine());
int sqr = num * num;
Console.Write($"Square of {num} is {sqr}");*/


//даны два числа - проверить является ли первое число квадратом второго
//
/*Console.WriteLine("Please input a");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input b");
int numB = Convert.ToInt32(Console.ReadLine());
int sqrB = numB * numB;
if (numA == sqrB)  
{
    Console.Write($"Number a = {numA} is a sqare of b {numB}");
}
else 
{
    Console.Write($"Number a = {numA} is not a sqare of b {numB}");
}*/

//на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N

/*Console.WriteLine("Please input N");
int numN = Convert.ToInt32(Console.ReadLine());
int crnt = numN * (-1); 
while (crnt < numN )
{
    Console.Write($"{crnt}; ");
    crnt++;
}*/

//получает на ввод трехзначное число и на выходе показывает последнюю цифру
Console.WriteLine("Please input N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($" last digit is {numN % 10}; ");


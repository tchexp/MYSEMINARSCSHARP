//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
//программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void Show3DArrayWithIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {

        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[k, i, j]} ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// //метод рандомизирующий существующий трехмерный массив
// //если встречаются повторяющееся числа то второе из них будет заменяться на рандомное,
// // до тех пор пока оно не станет уникальным и проверка переходит на следующею позицию
int[,,] AppendArrayRandomUnique(int[,,] array, int pos, int minValue, int maxValue)
{
    if (maxValue - minValue < array.GetLength(0) * array.GetLength(1) * array.GetLength(2))
    {
        Console.WriteLine("Randomization may lead to infinite loop, number of elements is greater than possible random ");
        return array;
    }
    if (pos >= array.GetLength(0) * array.GetLength(1) * array.GetLength(2))
    {
        return array; //выход из рекурсии
    }
    else
    {   //текущее положение указателя в массиве
        int d1Cur = pos / (array.GetLength(1) * array.GetLength(2));
        int d2Cur = pos % (array.GetLength(1) * array.GetLength(2)) / array.GetLength(2);
        int d3Cur = pos % (array.GetLength(1) * array.GetLength(2)) % array.GetLength(2);

        for (int i = 0; i < pos; i++)
        {
            int d1 = i / (array.GetLength(1) * array.GetLength(2));
            int d2 = i % (array.GetLength(1) * array.GetLength(2)) / array.GetLength(2);
            int d3 = i % (array.GetLength(1) * array.GetLength(2)) % array.GetLength(2);

            if (array[d1,d2,d3] == array[d1Cur,d2Cur,d3Cur]
                     ||
                array[d1Cur,d2Cur,d3Cur] < minValue
                     ||
                array[d1Cur,d2Cur,d3Cur] > maxValue                     
                )
            {
                array[d1Cur,d2Cur,d3Cur] = new Random().Next(minValue, maxValue + 1);
                AppendArrayRandomUnique(array, pos, minValue, maxValue);
            }
        }
        return AppendArrayRandomUnique(array, pos + 1, minValue, maxValue);
    }
}
// // // int pos = 3;

Console.Write("Please input array number of rows -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array number of columns -> ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array number of layers -> ");
int layers = Convert.ToInt32(Console.ReadLine());
int[,,] myArray = new int[layers,rows,columns]; //int[2, 3, 4] { { { 11, 12, 13, 14 }, { 15, 16, 17, 18 }, { 19, 19, 19, 19, } }, { { 21, 22, 23, 24 }, { 25, 26, 27, 28 }, { 29, 29, 29, 29 } } };
myArray[0, 0, 0] = new Random().Next(11, 99 + 1);//костыль, заполнение 0 позиции вне рекурсии
myArray = AppendArrayRandomUnique(myArray, 0, 11, 99);
Show3DArrayWithIndex(myArray);
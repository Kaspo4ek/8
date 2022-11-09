// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Array = GetArray(4, 4, 0, 10);
// PrintArray(Array);
// NumbersInDescendingOrder(Array);
// Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>");
// PrintArray(Array);



// void NumbersInDescendingOrder(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int z = 0; z < Array.GetLength(1) - 1; z++)
//             {
//                 if (Array[i, z] < Array[i, z + 1])
//                 {
//                     int temp = 0;
//                     temp = Array[i, z];
//                     Array[i, z] = Array[i, z + 1];
//                     Array[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Array = GetArray(4, 4, 0, 10);
// PrintArray(Array);
// MinimumAmountOfRows(Array);

// void MinimumAmountOfRows(int[,] array)
// {
//     int MinRows = 0;
//     int MinSumRows = 0;
//     int SumRows = 0;
//     for (int i = 0; i < Array.GetLength(1); i++)
//     {
//         MinRows += Array[0, i];
//     }
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             SumRows += Array[i, j];
//         }
//         if (SumRows < MinRows)
//         {
//             MinRows = SumRows;
//             MinSumRows = i;
//         }
//         SumRows = 0;
//     }
//     Console.Write($"{MinSumRows + 1} строка");
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Array = GetArray(2, 2, 2, 10, 99);
PrintArray2(Array);

bool FindElement(int[,,] Array, int Element)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                if (Array[i, j, z] == Element) return true;
            }
        }
    }
    return false;
}

//Вывод трехмерного массива
void PrintArray2(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Console.WriteLine($"  {Array[i, j, z]} ({i}, {j}, {z})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


// Заполнение числами Трехмерного массива
int[,,] GetArray(int m, int n, int b, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, b];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int z = 0;
            while (z < result.GetLength(2))
            {
                int element = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, element)) continue;
                result[i, j, z] = element;
                z++;
            }
        }
    }
    return result;
}

// // Заполнение числами двухмерного массива
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }


// // Вывод двухмерного массива
// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"  {Array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

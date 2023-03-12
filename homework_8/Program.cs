//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
// //7 4 2 1
// //9 5 3 2
// //8 4 4 2

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int max = array[i, j];
//             int maxindex = j;
//             for (int j1 = j; j1 < array.GetLength(1); j1++)
//             {
//                 if (array[i, j1] > max)
//                 {
//                     max = array[i, j1];
//                     maxindex = j1;
//                 }
//             }
//             array[i, maxindex] = array[i, j];
//             array[i, j] = max;
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);

// Show2DArray(array);

// int[,] sortedarray = SortArray(array);

// Show2DArray(sortedarray);




//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void MinRow(int[,] array)
// {
//     int minrow = 0;
//     int indexMinRow = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         minrow += array[0, j];
//     }
//     Console.WriteLine(minrow);//выводит сумму самой первой строки, чтобы самому не считать

//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int minrow2 = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             minrow2 += array[i, j];
//         }
//         Console.WriteLine(minrow2);//выводит сумму последующих строк, чтобы самому не считать
//         if (minrow2 < minrow)
//         {
//             minrow = minrow2;
//             indexMinRow = i;
//         }

//     }
//     Console.WriteLine($"min row ---> {indexMinRow + 1}");
// }

// MinRow(array);






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] ProductOfMatrices (int[,] arrayA, int[,] arrayB)
// {
//     int [,] productarray = new int[arrayA.GetLength(0),arrayB.GetLength(1)];
//     if (arrayA.GetLength(1)== arrayB.GetLength(0))
//     {
//         for (int i = 0; i < productarray.GetLength(0); i++)
//         {
//             for (int j = 0; j < productarray.GetLength(1); j++)
//                 {
//                     for (int k=0; k < arrayA.GetLength(1); k++)
//                     {
//                     productarray [i,j] = productarray [i,j] +(arrayA[i,k]*arrayB[k,j]);
//                     }
//                 }

//         }
//         return productarray;
//     }
//     else
//     {
//         Console.WriteLine ("matrices cannot be multiplied");
//         return productarray; //в случае если матрицы умножать нельзя, возвращает пустой массив
//     }
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of rows second array: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns second array: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element second array");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element second array");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// int[,] array2 = Create2DRandomArray(columns2, rows2, minValue2, maxValue2);
// Show2DArray(array);
// Show2DArray(array2);

// int[,] product = ProductOfMatrices(array, array2);
// Show2DArray(product);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//для вывода массива с разными двузначными числами размер массива не должен содержать более 89 элементов


// int[,,] Create3DRandomArray(int colums, int rows, int depth)
// {
//     int[,,] newArray = new int[rows, colums, depth];
//     int count=0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             for (int k=0; k< depth; k++)
//             {
//                 newArray[i, j, k] = 10 + count;
//                 count+=1;                
//             }
//         }

//     }
//     return newArray;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k=0; k< array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k})");
//             }
//             Console.Write("   ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of depth: ");
// int depth = Convert.ToInt32(Console.ReadLine());

// int[,,] array = Create3DRandomArray(columns, rows, depth);
// Show3DArray (array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];
int[,] SpiralArray(int n)
{
    int[,] array = new int[n, n];
    int num = 0;
    for (int count = 0; count<n/2+1; count++)
    {
        for (int i = count; i < n-count; i++)
        {
            num++;
            array[count, i] = num;
        }
        for (int i = count + 1; i < n - count; i++)
        {
            num++;
            array[i, n-1 - count] = num;
        }
        for (int i = n-2 - count; i >= count; i--)
        {
            num++;
            array[n-1 - count, i] = num;
        }
        for (int i = n-2 - count; i > count; i--)
        {
            num++;
            array[i, count] = num;
        }
    }

    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<10)
            {
            Console.Write(" " +array[i, j] + " ");
            }
            else
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

Show2DArray(SpiralArray(n));
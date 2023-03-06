// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomDoubleArray(int rows, int colums, double minValue, double maxValue)
// {
//     double[,] newArray = new double[rows, colums];
//     var rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             double num = rnd.NextDouble()*(maxValue-minValue)+minValue;
//             newArray[i,j]=Math.Round (num,3);
//         }
//     }

//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "|");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[,] array = Create2DRandomDoubleArray(rows, columns, minValue, maxValue);

// Show2DArray(array);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void SearchPosition(double[,] array, int rows, int colums)
// {
//     if (rows < array.GetLength(0) && colums < array.GetLength(1) && colums >= 0 && rows >= 0)
//     {
//         Console.WriteLine ($"Position = {array[rows, colums]}");
//     }
//     else Console.WriteLine ("Eror position");
// }

// Console.WriteLine("Input number of search rows: ");
// int srows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of search columns: ");
// int scolums = Convert.ToInt32(Console.ReadLine());

// SearchPosition(array, srows, scolums);





//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DRandomArray(int colums, int rows)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(0, 11);
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

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int[,] array = Create2DRandomArray(columns, rows);

// Show2DArray(array);

// double [] ArithmeticColums (int [,] array)
// {
//     double [] arithmeticarray = new double [array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arithmeticarray[j] = arithmeticarray[j] + (array[i,j]);//хотел добавить сюда деление на количество столбцов, но т.к. входной массив состоит из чисел int, то и деление на столбцы он тоже огругляет до целого.
//         }
//     }
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         arithmeticarray[j] = Math.Round(arithmeticarray[j]/array.GetLength(0),3);
//     }
//     return arithmeticarray;

// }

// double[] array2 = ArithmeticColums(array);
// ShowArray (array2);
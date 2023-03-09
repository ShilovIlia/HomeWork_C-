//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortArray(int[,] array)
{
    int[,] sortedarray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             int max = array[i, j];
            int maxindex = j;
            for (int j1 = j; j1 < array.GetLength(1); j1++)
            {
                if (array[i, j1] > max)
                {
                    max = array[i, j1];
                    maxindex = j1;
                }
            }
            array[i, maxindex] = array[i, j];
            array[i, j] = max;
        }
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);

Show2DArray(array);

int[,] sortedarray = SortArray(array);

Show2DArray(sortedarray);
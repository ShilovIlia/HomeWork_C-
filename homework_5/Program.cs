//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input Array size");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, 100, 999);
// ShowArray (myArray);

// void ShowEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i=0; i<array.Length; i++)
//     {
//         if (array[i]%2==0) count++;
//     } 
//     Console.WriteLine($"Array have {count} even numbers");
// }

// ShowEvenNumber(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input Array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input  minimal value of array element");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input  maximum value of array element");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray (myArray);

// void SumOddIndexArray(int[] array)
// {
//     int sum=0;
//     for (int i=0; i<array.Length; i=i+2)
//     {
//         sum = sum + array[i];
//     }
//     Console.WriteLine ($"Summa odd index array -> {sum}");
// }

// SumOddIndexArray(myArray);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input Array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input  minimal value of array element");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input  maximum value of array element");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// void DifferenceMaxMinNumerArr(int[] array)
// {
//     min = array[0];
//     max = array[0];
//         for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//     }
//     int rez = max-min;
//     Console.WriteLine($"Difference Max number and Min numer array -> {rez}");
// }
// DifferenceMaxMinNumerArr(myArray);

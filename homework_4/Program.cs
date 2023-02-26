// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Pow(int num, int stepen)
// {
//     int rez=1;
//     for (int i=1; i<=stepen; i++)
//     {
//         rez = rez*num;
//     }
//     return rez;
// }
// Console.WriteLine("Input num");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input stepen");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Pow(A, B));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigit(int N)
// {
//     int rez = 0;
//     while (N > 0)
//     {
//         rez = rez + N % 10;
//         N = N / 10;
//     }
//     return rez;
// }
// Console.WriteLine("Input N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumDigit(N));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
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

// ShowArray(CreateRandomArray(size, min, max));
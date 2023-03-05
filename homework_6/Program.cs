// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int [] Createarray (int size)
// {
//     int [] myarray = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         Console.Write($"Input {i+1} element of array:");
//         myarray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return myarray;
// }

// Console.Write("Input Array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = Createarray (size);

// void PositiveElementArray(int[] array)
// {
//     int count=0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]>=0) count++;
//     }
//     Console.WriteLine ($"{count} Positive Element Array");
// }

// PositiveElementArray(myArray);

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Input k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input  k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input  b2");
// double b2 = Convert.ToDouble(Console.ReadLine());

// void Intersection(double k1, double b1, double k2, double b2)
// {
//     double x = Math.Round((k1 - k2) / (b2 - b1), 2);
//     double y = Math.Round((k1 * x + b1), 2);
//     if (k1 == k2) Console.WriteLine("lines are paralel");
//     else Console.WriteLine($" dot intersection x = {x} y={y}");
// }

// Intersection(k1, b1, k2, b2);
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine ("Input first nuber:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input Second nuber:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1>num2)
// {
//     Console.WriteLine($"first nuber {num1} > second number {num2}");
// }
// else
// {
//     Console.WriteLine($"second nuber {num2} > first number {num1}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Input First nuber:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Second nuber:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Third nuber:");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (max < num2)
// {
//     max = num2;
// }
// else
// {

// }
// if (max < num3)
// {
//     max = num3;
// }
// else
// {

// }
// Console.WriteLine($"max: {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Clear();
// Console.WriteLine("Input nuber:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int result = num1 % 2;
// if (result == 0)
// {
//     Console.WriteLine($"{num1} - четное число");
// }
// else
// {
//     Console.WriteLine($"{num1} - нечетное число");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Clear();
// Console.WriteLine("Input nuber N:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// while (current <= num1)
// {
//     Console.Write(current + " ");
//     current = current + 2;
// }
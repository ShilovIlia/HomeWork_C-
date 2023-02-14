// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// void secondnum (int nmbr)
// {
//     int a=nmbr/10%10;
//     Console.WriteLine ($"Вторая цифра из трехзначного числа {nmbr} -> {a}");
// }
// Console.WriteLine ("Ведите трехзначное число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// secondnum(num1);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// void therdnum(int nmbr)
// {
//     if (nmbr < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         while (nmbr > 999)
//         {
//             nmbr /= 10;
//         }
//         Console.WriteLine(nmbr % 10);
//     }
// }
// Console.WriteLine ("Ведите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// therdnum(num1);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// void weekend(int num)
// {
//     if (num>1 && num<8)
//     {
//         if(num>5)
//         {
//            Console.WriteLine ("вых");
//         }
//         else
//         Console.WriteLine ("будни");
//     }
//     else
//     Console.WriteLine ("введите число от 1 до 7");
// }
// Console.WriteLine ("Ведите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// weekend(num1);
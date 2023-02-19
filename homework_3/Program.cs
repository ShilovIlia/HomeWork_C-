// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 12345
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Poli(int num)
// {
//     if (num > 10000 && num < 99999)
//     {
//         int num1 = num / 10000;
//         int num2 = num / 1000 % 10;
//         int num3 = num / 100 % 10;
//         int num4 = num / 10 % 10;
//         int num5 = num % 10;
//         if (num1==num5 && num2==num4)
//         {
//             Console.WriteLine($"{num} -> палиндром");
//         }
//         else
//         {
//             Console.WriteLine($"{num} -> не палиндром");
//         }
//     }
//     else
//     {
//         Console.WriteLine("это не пятизначное число");
//     }
// }

// Console.WriteLine("Введите пятизначное число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Poli (x);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistanse(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(ya - yb, 2) + Math.Pow(zb - za, 2)), 1);
// }
// Console.WriteLine("Введите XA:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите YA:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите ZA:");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите XB:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите YB:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите ZB:");
// double zb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($" Distance between our points -> {FindDistanse(xa, ya, za, xb, yb, zb)}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(int Num)
// {
//     int n = 1;
//     while (n<=Num)
//     {
//         Console.Write ($" {Math.Pow(n,3)},");
//         n++;
//     }
// }
// Console.WriteLine("Введите N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Cube(N);
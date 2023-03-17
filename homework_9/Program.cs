//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers (int n)
// {
//     Console.Write (n + " ");
//     if (n>1) ShowNumbers(n-1);
//     if (n<=0) ShowNumbers (n+1);
// }

// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers (n);

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// int SumBetweenNumbers(int m, int n)
// {
//     if (m < n)
//     {
//         return SumBetweenNumbers(m + 1, n) + m;
//     }
//     else
//     {
//         if(m > n)
//         {
//             return SumBetweenNumbers(m, n + 1) + n;
//         }
//         else return n;
//     }
// }
// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"sum between m and n = {SumBetweenNumbers(m, n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// подогнал под таблицу значений из википедии, заменив n и m

int Akkerman (int n, int m)
{
    if (n == 0)
    {
        return m+1;
    }
    else
    {
        if (m==0)
            {
            return Akkerman (n - 1, 1);
            }
        else
        return Akkerman(n-1, Akkerman(n,m-1));
    }
}

Console.WriteLine("Input n:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input m:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Akkerman function n&m = {Akkerman(b, a)}");
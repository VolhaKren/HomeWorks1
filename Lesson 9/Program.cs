// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNumbers (int n)
{
    if(n >= 1)
    {
        Console.Write(n + " ");
        if(n > 1) ShowNumbers(n - 1);
    }
}
ShowNumbers(5);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNumbers (int m, int n)
{
    if(n >= m) return m + SumOfNumbers (m+1, n);
    else return 0;
}

Console.WriteLine("Input a number M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberM < numberN) Console.WriteLine(SumOfNumbers(numberM, numberN));
if(numberM > numberN) Console.WriteLine(SumOfNumbers(numberN, numberM));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction (int m, int n)
{
    if(m == 0) return n +1;
    if(m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if(m > 0 && n > 0) return AckermannFunction(m-1, AckermannFunction(m , n - 1));
    else return 0;
}

Console.WriteLine("Input a number M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermannFunction(numberM, numberN));

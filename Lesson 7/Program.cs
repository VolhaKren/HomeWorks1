// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().NextDouble();
            array[i,j] = Math.Round(array[i,j], 2);
        }
    }

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
double max = Convert.ToInt32(Console.ReadLine());


double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int j = 0; j < columns; j++)
    {
        for(int i = 0; i < rows; i++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int FindAverage(int[,] array)
{
    double sum = 0;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "\n";
        sum=0;
        count=0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + "\t";
        }
    }
    return result
}

Console.WriteLine(result);
result="";

Console.Write("Input a numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/

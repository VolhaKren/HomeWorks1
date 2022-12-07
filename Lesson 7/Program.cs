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
/*
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

bool ShowValue(int row, int column, int[,] array)
{
    if((row > (array.GetLength(0))-1) || (column > (array.GetLength(1)-1)))
        Console.WriteLine("Value is absent");
    else Console.WriteLine("Value of your element: " + array[row, column]);
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

Console.WriteLine("Input a number of row: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of column: ");
int b = Convert.ToInt32(Console.ReadLine());
ShowValue(a, b, myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
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

void FindAverageInColumn (int[,] array)
{
    Console.WriteLine("Average in Columns");
        for(int j = 0; j< array.GetLength(1); j++)
        {
            double average = 0;
            for(int i = 0; i< array.GetLength(0); i++)
            {
                average += array[i, j];
            }
            Console.Write(Math.Round((average / array.GetLength(0)), 1)+ " ");
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

FindAverageInColumn(myArray);
*/
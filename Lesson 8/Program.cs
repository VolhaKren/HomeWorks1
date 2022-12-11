﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void ElementsDecreasing (int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {   
        for(int sortedSize = 0; sortedSize < array.GetLength(1); sortedSize++)
        {
            for(int j = 0; j < array.GetLength(1)-1-sortedSize; j++)
            {
                if(array[i,j] > array[i,j+1])
                {
                int temp = array[i, j+1];
                array[i,j+1] = array[i,j];
                array[i,j] = temp;
                }
            }
        }
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
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
ElementsDecreasing(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/


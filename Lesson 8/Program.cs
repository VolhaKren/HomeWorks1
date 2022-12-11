// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(i*j+1);
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

int[,] FindSumRows (int[,] array)
{
    int[,] rowArray = new int[array.GetLength(0), 1];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j< array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        rowArray[i,0]= sum;
    }
    return rowArray;
}

int FindMinSum(int[,] array)
{
    int minSum = array[0, 0];
    int minPos = 0;
        for(int i = 0; i< array.GetLength(0); i++)
        {
            if(array[i,0] < minSum)
            {
                minSum = array[i,0];
                minPos = i;
            }
        }
    return minPos;
}

Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
int[,] sumArray = FindSumRows(myArray);
int res = FindMinSum(sumArray);
Show2dArray(sumArray);
Console.WriteLine(res);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray(int rows, int columns, int layers)
{
    int[,,] array = new int[rows, columns, layers];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                array[i,j,k] = new Random().Next(10, 100);
            }
        }
    }

    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k< array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + "(" + i + "," +j  + ","+k  + ") " + "  ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

Console.Write("Input a numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of layers: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(m,n,l);
Show3dArray(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void ProductOfTwoMatrices(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0),arrayB.GetLength(1)];
    if(arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        for(int i=0; i < arrayA.GetLength(0); i++)
        {
            for(int l=0; l < arrayB.GetLength(1); l++)
            {
                int prod = 0;
                for(int j=0; j < arrayA.GetLength(1); j++)
                {
                    prod += arrayA[i,j] *arrayB[j,l];
                }
                arrayC[i,l] = prod;
                Console.Write(prod + " ");
            }
        Console.WriteLine();
        }
    }
    else Console.WriteLine("Wrong size of arrays A & B (You can multiply two matrices only if the number of columns of the first (A) is equal to the number of rows of the second (B)");
}

Console.WriteLine("Create array A:");
Console.WriteLine("Input a number of rows:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max1 = Convert.ToInt32(Console.ReadLine());
int[,] myArrayA = CreateRandom2dArray(m1,n1,min1,max1);
Show2dArray(myArrayA);
Console.WriteLine("Create array B:");
Console.WriteLine("Input a number of rows:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] myArrayB = CreateRandom2dArray(m2,n2,min2,max2);
Show2dArray(myArrayB);
Console.WriteLine();
ProductOfTwoMatrices(myArrayA, myArrayB);


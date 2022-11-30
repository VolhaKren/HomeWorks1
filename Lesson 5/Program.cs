 // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
 int[] CreateRandomArray(int size)
 {
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);

    return array;
 }

 void ShowArray(int[] array)
 {
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();
 }

 int CountUpEvens(int[] array)
 {
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
 }

 Console.Write("Input a numbers of elements: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int[] myArray = CreateRandomArray(n); 
 ShowArray(myArray);

 int CountEvens = CountUpEvens(myArray);
 Console.WriteLine("Count of evens is " + CountEvens);
 */

 //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
 int[] CreateRandomArray(int size, int minValue, int maxValue) 
 { 
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);

return array;
 }

 void ShowArray(int[] array)
 {
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
 }

int FindSumOddPositions(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i]%2==1)
            sum = sum + array[i];

    return sum;
}

Console.Write("Input a numbers of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int SumOddPositions = FindSumOddPositions(myArray);
Console.Write("Sum of elements in odd positions " + SumOddPositions);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue) 
 { 
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);

return array;
 }

 void ShowArray(int[] array)
 {
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
 }



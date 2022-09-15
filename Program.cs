/*
// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами 
// (для 10 чисел сделала). 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

int Even (int[] arr)
{   
    int quontity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            quontity += 1;            
        }
    }
    return quontity;    
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(Even(arr_1));
*/

/*
// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 0

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}

int Sum(int[] arr)
{   
    int n = arr[0];
    for (int i = 2; i < arr.Length; i+=2)
    {
        n += arr[i];            
    }
    
    return n;    
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(Sum(arr_1));
*/

/*
// Задача 3: Задайте массив вещественных чисел (выбрала массив из 10 элементов). 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

int MinimumSearch(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
    } 
    return min;  
}
int MaximumSearch(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
    } 
    return max;  
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(MinimumSearch(arr_1));
Console.WriteLine(MaximumSearch(arr_1));
int d = MaximumSearch(arr_1) - MinimumSearch(arr_1);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:  {d}");
*/
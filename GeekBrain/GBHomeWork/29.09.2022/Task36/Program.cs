﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int SumOfNonEvenNumbers(int[] array)
{
    int sum = default;

    for (int i = 1; i < array.Length; i++)
    {
      if ( array[i] % 2 == 1) sum = array[i] + sum;
    }

    return sum;
}

int[] arr = CreateArrayRndInt(4, -100, 100);
PrintArray(arr);
int sumOfNonEvenNumbers = SumOfNonEvenNumbers(arr);
Console.WriteLine($"Сумма нечетных элементов массива = {sumOfNonEvenNumbers}");

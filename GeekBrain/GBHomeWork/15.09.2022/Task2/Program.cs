﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число, ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min =number1;

if(max < number2) max = number2;
if(min > number2) min =number2;

Console.WriteLine($"Большее число {max} Меньшее число {min}");



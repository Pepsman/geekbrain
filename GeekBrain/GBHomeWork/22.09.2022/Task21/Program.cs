﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты первой точки, ");
Console.Write("X1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки, ");
Console.Write("X2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int coordx1, int coordy1, int coordz1, int coordx2, int coordy2, int coordz2)
{
    double res = Math.Sqrt(Math.Pow((coordx2 - coordx1), 2)+ Math.Pow((coordy2 - coordy1), 2) + Math.Pow((coordz2 - coordz1), 2));
    return res;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round (distance, 2, MidpointRounding.ToZero) );


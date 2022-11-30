﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m, n];
Random rnd = new Random();
int sum=0;
double sred = 0;

for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
    { 
        array[i,j] = Convert.ToInt32(rnd.Next(1, 10));
    }
 }
 for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
    { 
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
 }
    Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j ++)
{
    sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum  += array [i, j];
    }
    sred=sum / array.GetLength(0);
    Console.Write($"{sred} ");
}

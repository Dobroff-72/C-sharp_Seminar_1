﻿/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[rows,columns];
fillDoubleArray(array);
Print(array);

double[,] fillDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100,100);
            array[i,j] = Math.Round(array[i,j] + new Random().NextDouble(),1);
        } 
    }
    return array;
}

void Print(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "; ");
        }
        Console.WriteLine();
    }
}


/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}


void sortString(int[,] array)
{
    int[] SumRow = new int[array.GetLength(0)];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow[i] += array[i,j];
        }
    }
    int temp = SumRow[0];
    int NumberRows = 0;
    for (int i = 0; i < SumRow.Length; i++)
    {
        if(SumRow[i] <= temp)
        {
            temp = SumRow[i];
            NumberRows = i + 1;
        }
    }
    Console.WriteLine("Минимальная сумма элементов в строке: " + NumberRows);
    Console.WriteLine("Минимальная сумма элементов: " + temp );
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} \t");
        } 
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] array = new Int32[n,m];
fillArray(array);
PrintArray(array);
sortString(array);
Console.WriteLine();

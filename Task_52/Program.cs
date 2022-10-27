/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,columns];
fillArray(array);
Print(array);
Console.WriteLine();
Average(array);


int[,] fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
        } 
    }
    return array;
}

void Print(int[,] array)
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

void Average(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i,j];
        }
    double avg = Math.Round(summ / array.GetLength(0),1);

    Console.Write($"{avg}; ");
    }
}
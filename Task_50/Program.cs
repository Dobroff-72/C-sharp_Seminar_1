/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет
*/


Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату массива(номер строки) : [");
int findRows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите вторую координату массива(номер столбца):[{findRows},");
int findColumns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,columns];
fillArray(array);
Print(array);
FindIndex(array,findRows,findColumns);

int[,] fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
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

void FindIndex(int[,] array, int n1, int n2)
{
    if(n1 -1 >= array.GetLength(0) || n2 -1  >= array.GetLength(1))  // Указаны значения для указания координат с 1, а не с 0
    {
            Console.WriteLine("Такого элемента в массиве нет");    
    }
    else Console.WriteLine($"Число с заданными координатами [{n1},{n2}]: {array[n1-1,n2-1]}");
}

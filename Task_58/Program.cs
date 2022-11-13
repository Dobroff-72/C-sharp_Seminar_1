/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
А В
1 4 | 3 5
3 5 | 1 2
Результирующая матрица будет:
С
7 13
14 25
*/
Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] arrayOne = new Int32[n,m];
int [,] arrayTwo = new Int32[n,m];
int[,] matrixC = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
fillArray(arrayOne);
Console.WriteLine("первая матрица: ");
PrintArray(arrayOne);
Console.WriteLine();
fillArray(arrayTwo);
Console.WriteLine("вторая матрица: ");
PrintArray(arrayTwo);
Console.WriteLine();
Console.WriteLine("Конечный результат: ");
multiMatrix(arrayOne,arrayTwo);
PrintArray(multiMatrix(arrayOne,arrayTwo));




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


int[,] multiMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTwo.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < arrayOne.GetLength(1); k++)
                {
                    matrixC[i, j] += arrayOne[i, k] * arrayTwo[k, j];
                } 
            }
        }
    return matrixC;
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


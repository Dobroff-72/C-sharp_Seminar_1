/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());
int [,,] array = new Int32[x,y,z];

fillArray(array);
PrintArray(array);

void fillArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k <array.GetLength(2); k++)
            {
                {
                    array[i,j,k] = rnd.Next(10,100);
                }
            }
        }
    }
}



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k <array.GetLength(2); k++)
                 Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//БЕЗ Использования методов
/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
N = Math.Abs(N);
int count = 1;
if (N!=0)
{
    while (count <= N)
    {
        double i = Math.Pow(count, 3);
        Console.Write(i +" ");
        count ++; 
    }
}
else
{
Console.Write("0");
}*/

// С помощью метода

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
N = Math.Abs(N);

void Cubes(int N)
{
int count = 1;
if (N!=0)
{
    while (count <= N)
    {
        double i = Math.Pow(count, 3);
        Console.Write(i +" ");
        count ++; 
    }
}
else
{
    Console.Write("0");
}
}

Cubes(N);
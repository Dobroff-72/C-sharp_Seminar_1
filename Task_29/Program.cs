/*
Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите длину массива или 0 для рандомной длины: ");
int L = int.Parse(Console.ReadLine());
L =Math.Abs(L);

if(L == 0)
{
    int rnd = new Random().Next(0,10);  // Пусть будет рандомный массив не больше 10
    int[] array = new int[rnd];
    
    newArray(array);
    PrintArray(array);
}
else
{
    int[] array = new int[L];
    newArray(array);
    PrintArray(array);
}

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,999);  // Ограничимся трехзначными числами
    }
}

void PrintArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");
    }
    Console.WriteLine();
}

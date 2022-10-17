/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] fillMass(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void oddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+= 2)     // нечетные позиции, это ведь не то же самое, что и нечетный индекс? Если нечетный индекс, тогда поменять на i = 1
    {
        sum += array[i];  
    }
    Console.WriteLine("Cумма чисел на нечетных позициях: " + sum);
}

int[] array = new Int32[10]; // Массив из 10 чисел
fillMass(array,10,99);  // от 10 до 99
printArray(array);
oddIndex(array);
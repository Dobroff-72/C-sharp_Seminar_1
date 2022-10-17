/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] fillMassDouble(double[] array, int from, int to)
{   
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
        double num1 = rnd.Next(1,10);     //Рандомные числа для десятых
        num1 = num1 * 0.1;                
        array[i] = Math.Round(array[i] + num1, 1);      // Получаем рандомные целые и десятые числа
    }
    return array; 
}

double minMax(double[] array)
{
    double max=array[0];
    double min=array[0];
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        }
        Console.WriteLine ("Максимальное число в массиве " +max);
        Console.WriteLine ("Минимальное число в массиве " +min);
        double result =Math.Round((max - min),1);
        Console.WriteLine ("Разница между max & min :" +result);
return result;   
}
    

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }    
}

double[] array = new Double[10]; // Массив из 10 чисел


fillMassDouble(array, 0, 100);  // от 0 до 99
printArray(array);
minMax(array);


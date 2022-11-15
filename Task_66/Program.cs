/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.Write($"Type interval numbers from: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write($"Tо: ");
int stop = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
printNaturalNumbers(start);


void printNaturalNumbers(int n)
{
    if(n == stop) 
    {
        Console.WriteLine(n);
        Sum += n;
        Console.WriteLine($"Cумма чисел в интервале: {Sum}");
    }
    else {
        Console.Write($"{n}, ");
        Sum += n;
        printNaturalNumbers(n+1);
    }
}

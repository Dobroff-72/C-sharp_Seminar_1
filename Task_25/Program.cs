/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Введите число А: ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите cтепень B: ");
int N2 = int.Parse(Console.ReadLine());
Degree(N1, N2);



void Degree(int N1, int N2)
{
    double result = Math.Pow(N1, N2);
    Console.Write("Число А в степени В равно: " + result ); 
}


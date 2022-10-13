/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/


Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
N =Math.Abs(N);
Sum(N);



void Sum(int N)
{
int NewNum = N;
int sum = 0;
while(N > 0)
{
    NewNum = N % 10;
    sum = sum + NewNum;
    N = N / 10;
}
Console.WriteLine("Сумма цифр в числе: " +sum);
}

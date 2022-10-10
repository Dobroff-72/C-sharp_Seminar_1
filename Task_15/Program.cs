/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
while (day < 1 || day > 7)
{
    Console.WriteLine("Пожалуйста, введите день недели");
    int day2 = Convert.ToInt32(Console.ReadLine());
    day = day2;
}
if (day >=1 && day <= 5)
{
    Console.WriteLine("Работайте, братья");
}
else
{
    Console.WriteLine("Отдыхайте");
}
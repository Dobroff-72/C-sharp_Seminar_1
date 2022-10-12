/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
num =Math.Abs(num);
int OldNum = num;
int newNum = 0;
while(num > 0)
{
    int i = num % 10;
    newNum = newNum * 10 + i;
    num = num / 10;
}
if(newNum == OldNum)
    {
      Console.WriteLine("Данное число является палиндромом");  
    }
else
{
    Console.WriteLine("Нет, это не палиндром");
}
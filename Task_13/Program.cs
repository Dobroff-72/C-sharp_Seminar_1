/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
num =Math.Abs(num);

if (num < 100) 
{
    Console.WriteLine("Третьей цифры в числе нет");
}
if(num >= 100 && num < 1000)
{ 
    num = num % 10;    
    Console.WriteLine(("Третья цифра: " + num));
}

if (num >=1000) 
{
    while(num / 100 >= 10)
        {
            num = num / 10;
        }
    Console.WriteLine("Третья цифра: " + num % 10);
} 

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//y - y = k1*x+b1-(k2*x+b2) => x= b1-b2/ k2-k1 
//y = k2*x+b2

Console.Write("Введите k1 >");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1 >");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 >");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 >");
double b2 = Convert.ToDouble(Console.ReadLine());

void FindCoord (double k1, double b1,double k2,double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)Console.WriteLine("Прямые параллельны");
    else{
    double xCoord = Math.Round((b1 - b2) / (k2 - k1),2);
    double yCoord = Math.Round((k2 * xCoord + b2),2);
    
    Console.WriteLine($"Точка пересечения прямых  y = {k1} * x + {b1} и y = {k2} * x + {b2}");
    Console.WriteLine($"Имеет координаты :({xCoord}; {yCoord})");
    }
}

FindCoord(k1,b1,k2,b2);

Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.Write("Максимальное число: ");
    Console.Write(a);
}
if(a < b)
{
    Console.Write("Максимальное число: ");
    Console.Write(b);
}
if(a == b)
{
    Console.Write("Числа равны");
}

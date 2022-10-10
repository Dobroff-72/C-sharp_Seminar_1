
 /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */
  //Сложный, длинный, но работает oO)
  
 int SecondNum(int n)
{
 int result = n / 10 % 10;
 if(result < 0)
 {
    result *= -1;                 
 }
 return result;
}


 Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
while (n > -100 & n < 100 | n > 999 | n < -999 )
{
    Console.WriteLine("Введите трехзначное число!!!");
    int a = Convert.ToInt32(Console.ReadLine());
    n = a;                                            //Пока что не понял, как сделать без дополнительной переменной.

}

int res = SecondNum(n);
Console.WriteLine(res);

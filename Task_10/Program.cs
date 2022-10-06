 //Сложный, длинный, но работает oO)
 
 
 int SecondNum(int n)
{
 int result = n / 10 % 10;
 if(result < 0)
 {
    result *= -1;                 //Если число отрицательное, то перевод в положительное
 }
 return result;
}


 Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
while (n > -100 & n < 100 & n != 000 | n > 999 | n < -999 )
{
    Console.WriteLine("Введите трехзначное число!!!");
    int a = Convert.ToInt32(Console.ReadLine());
    n = a;                                            //Пока что не понял, как сделать без дополнительной переменной.

}

int res = SecondNum(n);
Console.WriteLine(res);

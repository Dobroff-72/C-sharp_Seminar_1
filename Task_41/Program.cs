/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/



//Буду благодарен, если подскажете каким способом сделать цикл, чтобы если ввел не число, он попросил повтор ввода("Введите число")
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Сколько чисел желаете ввести?");

int M = int.Parse(Console.ReadLine());
int[] array = new Int32[M];
int sum = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число № {(i+1)}: ");
    array[i] = int.Parse(Console.ReadLine());
    if(array[i]>0){
        sum=sum+1;
    }
}

Console.WriteLine("Количество положительных чисел: "+sum);

printArray(array);


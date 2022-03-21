//1 Задач1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int sumNumber(int num)
{
    int sum = 0;
    int i = 1;
    while (i <= num)
    {
        sum = sum + i;
        i++;
        Console.WriteLine($"{sum} + {i} = {sum + i}");
    }  
    return sum;
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1) Console.WriteLine("Ввели не натуральное число");
sumNumber(a);
*/


void sumNumber(int num)
{
    int sum = 0;
    int i = 1;
    while(i <= num)
    {
        Console.WriteLine($"{sum} + {i} = {sum+i}");
        sum = sum + i;
        i++;
    }
}
Console.WriteLine("Введите положительное число");
int a = Convert.ToInt32(Console.ReadLine());
sumNumber(a);

/*
int sumNumber(int num)
{
    int sum = 0;
    int i = 1;
    while(i <= num)
    {
        Console.WriteLine($"{sum} + {i} = {sum+i}");
        sum = sum + i;
        i++;  
    }
  
    return sum;
}
Console.WriteLine("Введите положительное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 0) Console.WriteLine("Число введено некорректно");
else
Console.WriteLine($"Сумма чисел от 1 до {a} = {sumNumber(a)}");

*/
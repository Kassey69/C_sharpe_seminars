/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int sumNumber(int num)
{   
    int sum = 0;
    while (num > 0)
    {   
        Console.WriteLine($"{sum} + {num % 10} = {sum + (num % 10)}");
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("Число некорректно");
Console.WriteLine($"сумма цифр в числе = {sumNumber(number)}");

//то что нельзя разделить на 10 является остатком, 1 % 10 = 1
/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*//*
int function(int num)
{
    int n = (num / 10) % 10;
     return n;
}
int number = new Random().Next(100, 999);
    Console.WriteLine(" Current number " + number + " leave 2nd digit number " + function(number) + " " );
*/
    void function(int num)
{
    if (num.ToString().Length == 3) 
    {
        Console.WriteLine(num.ToString()[1]);
    }
    else
    {
        Console.WriteLine("Трех цифр нет");
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
function(number);
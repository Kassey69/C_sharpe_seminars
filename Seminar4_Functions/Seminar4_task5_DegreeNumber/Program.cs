/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/
int cycleNumber(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        Console.WriteLine($"{res} * {numA} = {res * numA}");
        res = res * numA;
    }
    return res;
}
Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число {numberA} в степени {numberB} = {cycleNumber(numberA, numberB)}"); 

/*
void cycleNumber(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        Console.WriteLine($"{res} * {numA} = {res * numA}");
        res = res * numA;
    }
}
Console.WriteLine("enter numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
cycleNumber(numberA, numberB);
*/

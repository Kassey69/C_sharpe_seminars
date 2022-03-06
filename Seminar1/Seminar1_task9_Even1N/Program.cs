/*Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
/*
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int t = 1;
while (t <= n)
{
    if (t % 2 == 0)
        Console.Write(t + " ");
    t++;
}
*/
/*
void even(int n)
{
    int a = 1;
    while (a <= n)
    {
        Console.Write(a+ " ");
        a++;
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
even(number);
*/
int even(int n)
{
    int a = 1;
    while (a <= n)
    {
        Console.Write(a+ " ");
        a++;
    }
    return a;
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
even(number);

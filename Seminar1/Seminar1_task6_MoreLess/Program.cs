/*Задача 1: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
/*
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine(number1+ " больше чем " + number2);
}
else
{
    Console.WriteLine(number2+ " больше чем "+ number1);
}
*/


int more(int a, int b)
{
    /* int max;
     if (a > b) max = a; 
     else max = b;
     return max;*/
     /*
     int max = a;
     if(max<b) max=b;
     return max;
     */
     
   if (a > b)
    {
        Console.WriteLine("Число "+a +" больше "+b);
        return a;
    }
    else
        Console.WriteLine("Число "+b +" больше "+a);
        return b;
}
Console.Write("Введите 1-е число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число ");
int number2 = Convert.ToInt32(Console.ReadLine());
more(number1, number2);
/*
void more(int a, int b)
{
    if (a > b)  Console.WriteLine("Число "+a +" больше "+b); 
    else Console.WriteLine("Число "+b +" больше "+a);       
}
Console.Write("Введите 1-е число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число ");
int number2 = Convert.ToInt32(Console.ReadLine());
more(number1, number2);
*/
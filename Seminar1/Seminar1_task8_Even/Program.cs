/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0) 
{
    Console.WriteLine("число положительное");
}
else 
{
    Console.WriteLine("число отрицательное");
}
if (number % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
     Console.WriteLine("число нечетное");
}
*/
/*
int even(int num)
{
    if(num % 2 == 0)
    {
        Console.WriteLine("Число четное");
        return num;
    }
    else   
       Console.WriteLine("Число нечетное"); 
       return num;   
}
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
even(number);
*/

void even(int num)
{
    if(num % 2 == 0) Console.WriteLine("Число четное");
    else Console.WriteLine("Число нечетное"); 
    
}
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
even(number);

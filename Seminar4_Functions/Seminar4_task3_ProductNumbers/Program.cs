// 3 Задача. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int composition(int num)
{
    int a1 = 1; int a2 = 1; int res = 0;
    while(a1 <= num)
    {
        res = a1 * a2;
        a2 = res;
        a1++;
        Console.WriteLine($"{a1} * {a2} = {a1 * a2}");
    } 
         return res;
}

Console.WriteLine("enter n");
int n = Convert.ToInt32(Console.ReadLine());
composition(n);

*/
/*
void composition(int num)
{
    int count = 1;
    int i = 1;
    while (i <= num)
    {    
        Console.WriteLine($"{count} * {i} = {count * i}");
        count = count * i;
        i++;
    }
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
composition(number);
*/
int composition(int num)
{
    int count = 1;
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{count} * {i} = {count * i}");
        count = count * i;
        i++;
    }
    return count;
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("Число некорректно");
Console.WriteLine($"произведение чисел от 1 до {number} = {composition(number)}");


// Задание 2.По двум заданным числам проверять является ли первое квадратом второго
/*
Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_value2 = value2 * value2;

if (kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа соответствует первому");
}
else
{
Console.WriteLine("Первое число не является квадратом второго");

}
*/


void square(int a, int b)
{   
    
    if(a == b*b) Console.WriteLine("Квадрат второго числа соответствует первому");
    else Console.WriteLine("Первое число не является квадратом второго");
}
Console.WriteLine("Введите первое число");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int value2 = Convert.ToInt32(Console.ReadLine());

square(value1, value2);


/*
int square(int a, int b)
{   
    
    if(a == b*b) 
    {
        Console.WriteLine("Квадрат второго числа соответствует первому");
        return a;
    }
    else
    
        Console.WriteLine("Первое число не является квадратом второго");
        return a;
    
}
Console.WriteLine("Введите первое число");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int value2 = Convert.ToInt32(Console.ReadLine());

square(value1, value2);
*/
/*Задание 3. Необходимо написать программу. 
берет на вход 2 числа и определяет является ли одно 
число кратное другоему. И если кратно то вывести на экран. 
В противном случае указать что не кратно и вывести остаток от деления
*/
void function(int num1, int num2) // void ничего не возвращает, просто отрабатывает и все, как Console.Write
{
    if (num1 < num2)
    {                       //мы переносим значение большего num2 в num1, меняем числа в них местами через a
        int a = num1;     //потому что по формуле ниже нам надо, чтоб именно цифра в num1 была больше              
        num1 = num2;
        num2 = a; 
    }
        if (num1 % num2 == 0)
        {
            int result = num1 / num2;
            Console.WriteLine("1 Число кратно второму и результат =  " + result);
        }
        else
        {
        Console.WriteLine("не кратно и не делится "+ num1 % num2); //выводим остаток от
        }
}
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

function(number1, number2);

/*
void function(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 % num2 == 0)
        {
            int result = num1 / num2;
            Console.WriteLine("1 Число кратно второму и результат =  " + result);
        }
        else
        {
        Console.WriteLine("не кратно и не делится ");
        }
    }
    else 
    {
        if (num2 % num1 == 0)
        {
            int result = num2 / num1;
            Console.WriteLine("1 Число кратно второму и результат =  " + result);
        }
        else
        {
            Console.WriteLine("не кратно и не делится ");
        }
    }
}
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

function(number1, number2);*/
/*задение 4. Принять на вход одно число и проверяет его на кратность двум другим  7 и 23.
и вводим потом 2 числа на которые проверяем на  кратность 1-го числа
*/
/*
Console.Write("Введите первое число: ");
double value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double value2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
double value3 = Convert.ToInt32(Console.ReadLine());

if (value1 % value2 == 0 && value1 % value3 == 0)
{
   
    Console.WriteLine("кратно");
}
else
{    
Console.WriteLine("не кратно ");
}
*/
void Proverka(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Число " +num1 + " кратно числам "+ num2 +" и "+num3);
    }
    else
    {
        Console.WriteLine("Число некратно");
    }
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Proverka (num1, num2, num3);
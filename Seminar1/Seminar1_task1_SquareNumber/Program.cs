// Задание 1. Вывести квадрат числа
/*/int value = 5;
Console.Write("Квадрат числа = " + value*value);/*/
/*
Console.Write("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value * value;
Console.Write("Квадрат числа = " + kvadrat_value);
*/
//это я написал прогу с помощью функции

int results(int a)
{
    int result = a * a;
    return result;
}
Console.WriteLine("введите число ");
int res = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Квадрат числа " +res+ " равен " + results(res));
/*
void Result(int a)
{
    int result = a*a;
    Console.WriteLine("Квадрат числа равен " + result);
}
Console.WriteLine("введите число ");
int res = Convert.ToInt32(Console.ReadLine());
Result(res);*/

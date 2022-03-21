// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void DLina(int N)
{

    int l = 1;
    //while (Math.Abs(N / 10) > 1) //Функция Math.abs () возвращает абсолютное 
    //положительное значение переданного ей параметра. 
    while (N / 10 > 1 || N / 10 < 0)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("кОЛИЧЕСТВО ЦИФР В ВВЕДЕННОМ ЧИСЛЕ " + l);
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

DLina(number);

/*
void count(int num)
{
    int counts = 0;
    while(counts < num.ToString().Length) counts++;
    Console.WriteLine("В числе " + counts + " цифр");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
count(number);
*/
/*
void countNumber(int num)
{
    int count = 0;
    while (count < num.ToString().Length)
        count++;
        Console.WriteLine($"В числе {count} цифр");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
countNumber(number);
*/
/*
int countNumber(int num)
{
    int count = 0;
    while (count < num.ToString().Length)
        count++;
        Console.WriteLine($"В числе {count} цифр");
    return count;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
countNumber(number);
*/
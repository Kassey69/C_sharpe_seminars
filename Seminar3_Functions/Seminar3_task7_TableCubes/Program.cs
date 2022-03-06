/*Задача 23. Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void tableСubes(int n)
{
    int a = 1;
    while (a <= n)
    {
        int result = a * a * a;
        Console.WriteLine(a + " в кубе = " + result);
        a++;                                            // a+=2 -- он будет прыгать через числа с шагом 2
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
tableСubes(number);
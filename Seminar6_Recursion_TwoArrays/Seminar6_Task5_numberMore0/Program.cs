/*Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.WriteLine($"Введите количество чисел вводимых пользователем");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int num = 0;
int countPlus = 0;
int countMinus = 0;
Console.WriteLine($"Теперь последовательно вводите {M} чисел ");
for (int i = 0; i < array.Length; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) countPlus = countPlus + 1;
    else countMinus = countMinus + 1;      
        Console.Write($"Пользователь ввел чисел > 0 : {countPlus}; ");
        Console.Write($"Пользователь ввел чисел <= 0 : {countMinus} ");
        Console.WriteLine();
}
Console.Write($"Чисел больше 0 ввёл пользователь = {countPlus} ");
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка/

int n = 4,
    m = 4;
int[,] array = new int[n, m];
int[] sum = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[i] = sum[i] + array[i, j];
    }
}
for (int i = 0; i < n; i++)
{
    Console.Write($"{sum[i]} ");
}
Console.WriteLine();
int min = sum[0];
int Imin = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            Imin = i + 1;
        }
    }
}
Console.Write($"номер строки {Imin} с наименьшей суммой элементов {min}");
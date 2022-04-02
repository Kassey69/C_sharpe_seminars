/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
                //(0.0, 0.1, 0.2, 0.3) 
                //(1.0, 1.1, 1.2, 1.3)
                //(2.0, 2.1, 2.2, 2.3)
                //(3.0, 3.1, 3.2, 3.3)
                //(4.0, 4.1, 4.2, 4.3)

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
*/
int n = new Random().Next(3, 9);
int m = new Random().Next(3, 9);
int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Введите позицию элемента массива строки");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите позицию элемента массива столбца");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 >= array.GetLength(0) || num2 >= array.GetLength(1))
Console.Write($"Такого числа нет "); 
//int input = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (num1 == i && num2 == j)
        {
            Console.Write($"Значение введенного элемента = {array[i, j]} "); break;
        }
        // if (num1 >= array.GetLength(0) || num2 >= array.GetLength(1))
        // {
        //   input = 1;  
        // }
    }
}
//if(input == 1) Console.Write($"Такого числа нет "); 
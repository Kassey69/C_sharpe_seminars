﻿// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)

int n = 2; int m = 2; int h = 2;
int[,,] matrix = new int[n, m, h];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < h; k++)
        {
            matrix[i, j, k] = new Random().Next(11, 99);;  
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < h; k++)
        {
           Console.Write($"{matrix[i, j, k]} ({i} {j} {k}) "); 
        }
        Console.WriteLine();
    }   
}
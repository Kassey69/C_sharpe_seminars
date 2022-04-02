//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
void TwoArrays(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(10,100);
        Console.Write($"{array[i,j]} ");
    }  
    Console.WriteLine();
}
}
Console.WriteLine($"Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n,m];
TwoArrays(array);
*/

int m = 3;
int n = 4;
int [,]  array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j <  array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
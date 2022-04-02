/*Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
                //(0.0, 0.1, 0.2, 0.3) 
                //(1.0, 1.1, 1.2, 1.3)
                //(2.0, 2.1, 2.2, 2.3)
                //(3.0, 3.1, 3.2, 3.3)
*/
int n = 4;
int m = 4;
int [,] array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{       
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = i + j;
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
/*
void TwoArrays(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;
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

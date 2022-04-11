// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3

int[,] RandomMattix(int n, int m)
{
int[,] matrix = new int[n, m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
    return matrix;
}
int[,] Sweep(int[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int save = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = save;
}
return matrix;
}
Console.WriteLine();

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
}
int[,] matrix = RandomMattix(3,4);
Console.WriteLine();
PrintMatrix(Sweep(matrix));





/*
int n = 3; int m = 4;
int[,] matrix = new int[n, m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int save = matrix[0, j];
    matrix[0, j] = matrix[n - 1, j];
    matrix[n - 1, j] = save;
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
*/
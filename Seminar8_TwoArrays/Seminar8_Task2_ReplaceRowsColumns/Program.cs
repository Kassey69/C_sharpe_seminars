// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int[,] RandomMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    if (matrix.GetLength(0) != matrix.GetLength(1)) Console.Write("");
    else
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
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3
int [,] sweep(int[,] matrix)
{
        int temp;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        } 
        return matrix;
}
void print(int[,] matrix)
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

Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = RandomMatrix(n,m);
//int[,] matrix = new int[n, m];
if (n != m) Console.WriteLine("Замена невозможна");
else
{
   // int[,] matrix = RandomMatrix(n,m);
//RandomMatrix(n,m);
Console.WriteLine();
print(sweep(matrix));
}
















/*
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
if (n == m) 
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3
int count = 0;
for (int i = 0; i < n && count <= (n*m)/2+1; i++)
{
    for (int j = i; j < m; j++)
    {
        int temp = matrix[i,j];
        matrix[i,j] = matrix[j,i];
        matrix[j,i] = temp;
        //Console.Write(matrix[i, j] + " ");
        count++;
    }
   
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
}
else Console.WriteLine($"End");
*/

/*
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
if (n == m) 
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3
int temp;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = i; j < matrix.GetLength(1); j++)
    {
        temp = matrix[i,j];
        matrix[i,j] = matrix[j,i];
        matrix[j,i] = temp;
        //Console.Write(matrix[i, j] + " ");      
    }
  
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
}
else Console.WriteLine($"End");
*/

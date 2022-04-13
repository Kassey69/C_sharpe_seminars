// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
//---------------------------------------------------------------------------
// -> удалить из матрицы все нули и переписать в меньшую матрицу на 1 размер
//---------------------------------------------------------------------------

int [,] RandomMatrix(int n, int m)
{
    int [,] matrix = new int[n,m];
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
Console.WriteLine();
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3
int [,] create(int [,] matrix)
{
int minI = 0,
    minJ = 0,
    min = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min) 
        {
            min = matrix[i, j];
            minI = i;
            minJ = j;
        }
    }
}
//Console.WriteLine(minI + " " + minJ +  " " + min);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    matrix[i,minJ] = 0;
    int save = matrix[i,minJ];
}
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[minI,j] = 0;
    }
    return matrix;
}
void printCreate(int[,] matrix)
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
int[,] matrix = RandomMatrix(n, m);
Console.WriteLine();
printCreate(create(matrix));





/*
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine();
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3

int minI = 0,
    minJ = 0,
    min = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min) 
        {
            min = matrix[i, j];
            minI = i;
            minJ = j;
        }
    }
}
//Console.WriteLine(minI + " " + minJ +  " " + min);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    matrix[i,minJ] = 0;
}
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[minI,j] = 0;
    }


 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
*/

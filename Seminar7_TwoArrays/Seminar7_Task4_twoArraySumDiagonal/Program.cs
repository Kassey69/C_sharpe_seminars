/* Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */
// квадрат должен быть
                //(0.0, 0.1, 0.2, 0.3) 
                //(1.0, 1.1, 1.2, 1.3)
                //(2.0, 2.1, 2.2, 2.3)
                //(3.0, 3.1, 3.2, 3.3)

int n = 5;
int [,] matrix = new int[n,n];
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i,j] = i + j;
        if(i == j)
        {
           sum = sum + matrix[i,j];
        }
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
Console.Write($"{sum} ");

/*
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void TwoArrays(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            //array[i,j] = new Random().Next(10,100);
            // Console.Write($"{array[i,j]} ");
            if (i == j) 
            {
                sum = sum + array[i, j];
                 
                //array[i, j] = Math.Pow(i + j,2);
            }
           Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.Write($"{array[0, 0]} + {array[1, 1]} + {array[2, 2]} + {array[3, 3]} = {sum}");
    Console.WriteLine();
    Console.WriteLine(sum);
}
int n = 4;
int m = 4;
int[,] array = new int[n, m];
printArray(array);
Console.WriteLine();
TwoArrays(array);
*/
                //(0.0, 0.1, 0.2, 0.3) 
                //(1.0, 1.1, 1.2, 1.3)
                //(2.0, 2.1, 2.2, 2.3)
                //(3.0, 3.1, 3.2, 3.3)

/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. 
                //(0.0, 0.1, 0.2, 0.3) 
                //(1.0, 1.1, 1.2, 1.3)
                //(2.0, 2.1, 2.2, 2.3)
                //(3.0, 3.1, 3.2, 3.3)   */
int n = 4;
int m = 4;
int[,] array = new int[n, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1,9);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {  
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];    
        }
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}                
/*
void printArray(int[,] array)
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
void TwoArrays(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i,j] = new Random().Next(10,100);
           // Console.Write($"{array[i,j]} ");
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i,j] * array[i,j];
                 //array[i, j] = Math.Pow(i + j,2);
            }   
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine($"Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
printArray(array);
Console.WriteLine();
TwoArrays(array);
*/

/* Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
3, 4 ->  1 1 1 1           //(0.0, 0.1, 0.2, 0.3) 
         1 0 0 1           //(1.0, 1.1, 1.2, 1.3)
         1 1 1 1           //(2.0, 2.1, 3.2, 4.3)
*/

void FillArray(int[,] matrix) // Fill - заполнить
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[0, j] = 1; 
            matrix[i, 0] = 1;
            matrix[i, matrix.GetLength(1) - 1] = 1;
            matrix[matrix.GetLength(0) - 1, j] = 1;
            Console.Write(" " + matrix[i, j]);    
        }
        Console.WriteLine();
    }
}
Console.WriteLine($"Введите количество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, column];
FillArray(array);

/*
void PrintArray(int[,] matrix)
{   
for (int i = 0; i < matrix.GetLength(0); i++) 
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        Console.WriteLine("Введите элементы массива {0},{1}", i , j);
        matrix[i,j] = Convert.ToInt32(Console.ReadLine());
    } 
}      
void FillArray(int[,] matrix) // Fill - заполнить
{  
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write("{0}  ", matrix[i,j]);
        }
    }
}        
Console.WriteLine($"Введите количество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row,column];
PrintArray(array);
FillArray(array);
*/
/*
Console.WriteLine("Введите количество строк массива");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[row, column];
for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++) // сначала заполняется внутренний for и переход на следущую строку
    //(0.0, 0.1, 0.2, 0.3) 
    //(1.0, 1.1, 1.2, 1.3)
    {
        Console.WriteLine("Введите X{0},{1} эллемент массива A", i, j);
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
for (int i = 0; i < row; i++) 
{
    Console.WriteLine();    // переъод на следующую строку
    for (int j = 0; j < column; j++)
    {    
        Console.Write("{0}\t", array[i, j]); //визуально переносим на экран монитора
        //ранее вручную заполненную форму элементов строк, через столбцы
    }
}
*/
       


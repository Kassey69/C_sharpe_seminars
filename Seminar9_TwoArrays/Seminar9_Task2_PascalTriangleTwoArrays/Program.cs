//  Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
// методов void , который принимает на вход натуральное число
// и оно будет указывать порядок генома ньютона 
// Если пользователь ввел 3 , необходимо вывести треугольник до разряда включительно 
// где 1 3 3 1 , а если 5 то как на рисутке вывести, нарисовать
//----------------------------------------------------------------------
// и на домашнюю работу как это можно отобразить, как это можно записать
//----------------------------------------------------------------------

int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size ; i++) // тут j второй for не нужен. потому что size и там и там, за обоих
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;   
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }   
    }
    printTriangle(triangle);
    return triangle;
}
CreateTriangle(5);
void printTriangle(int[,] triangle)
{   
    Console.WriteLine();
    for (int i = 0; i < triangle.GetLength(0); i++)
    {   
        for (int j = 0; j < triangle.GetLength(0) - i; j++)
        {
           Console.Write("   ");      
        } 
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{triangle[i, j]}     ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }        
}


/*
int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++) // тут j второй for не нужен. потому что size и там и там, за обоих
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }
        // мы прибавляем два рядом стоящих элемента (j) и переносим сумму на следующую строчку в (i)
        // единицы составляют как раз сумму чисел треугольника 
        // (i - 1) -- означает, что мы рассматриваем число в последней строке, 
        //а (j - 1) на каком месте в строке оно находится и (j - 1) + j) означает что числа смежные складываются
        //и сумма переносится на следующую строчку по циклу
        //1 0 0 0 0
        //1 1 0 0 0
        //1 2 1 0 0 
        //1 3 3 1 0
        //1 4 6 4 1    
    }
    //gTriangle(triangle);
    printTriangle(triangle);
    return triangle;
}
// Console.WriteLine($"Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
CreateTriangle(5);
void printTriangle(int[,] triangle)
{
    Console.WriteLine();
    for (int i = 0; i < triangle.GetLength(0); i++)
    {    
        for (int j = 0; j < triangle.GetLength(0) - i; j++)
        {
           Console.Write("   ");      
        } 
        for (int k = 0; k <= i; k++)
        {
            Console.Write($"{triangle[i, k]}     ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }        
}
// Console.WriteLine($"Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
*/



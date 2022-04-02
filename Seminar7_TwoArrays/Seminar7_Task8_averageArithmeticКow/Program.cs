//Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждой строке.
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
double[] summ = new double[n];
for (int i = 0; i < n; i++) // последовательность заполнения, сначала строки, но по столбцам
{
    for (int j = 0; j < m; j++) // внутренний цикл заполнения строк по столбцам
    {
        array[i, j] = new Random().Next(1, 10); //рандомные значения для елементов матрицы
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
//      m1   m2   m3   m4
// n1 (0.0, 0.1, 0.2, 0.3) n1
// n2 (1.0, 1.1, 1.2, 1.3) n2
// n3 (2.0, 2.1, 2.2, 2.3) n3
}   
for (int i = 0; i < n; i++) //все так же , подсчет. строки по столбцам
{
    for (int j = 0; j < m; j++) //внутренний цикл посчета строк по столбцам
    {
       // Console.Write($"{array[i, j]} "); //выводить матрицу нельзя повторно, значения перепутаются
        summ[i] = summ[i] + array[i, j]; //подсчет суммы колонки
    }
}
Console.Write($"Среднее арифметическое элементов в каждой строке: ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{Math.Round(summ[i] / m,1)} ");
}
Console.WriteLine();
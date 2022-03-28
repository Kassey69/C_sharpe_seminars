/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
    Console.Write($"Массив заполненный случайными числами = ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100) + new Random().NextDouble();

        Console.Write($"{Math.Round(array[i],2)} ");
    }
    Console.WriteLine();
    double max = 0;
    double max2 = 0;
    double min = 0;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max2 = max;
            max = array[i];
        }
        else
        if (array[i] != max && array[i] > max2) max2 = array[i];
    }
    Console.WriteLine($"Максимальный элемент = {Math.Round(max,2)} ");
    min = max2;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    result = max - min;
    Console.WriteLine($"Минимальный элемент = {Math.Round(min,2)} ");
    Console.Write($"Разница между элементами массива: {Math.Round(max,2)} - {Math.Round(min,2)} =  {Math.Round(result,2)} ");

/*
void arrayRandom(int[] array)
{
    Console.Write($"Массив заполненный случайными числами = ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void differenceArray(int[] array)
{
    int max = 0;
    int max2 = 0;
    int min = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max2 = max;
            max = array[i];
        }
        else
        if (array[i] != max && array[i] > max2) max2 = array[i];
    }
    Console.WriteLine($"Максимальный элемент = {max} ");
    min = max2;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    result = max - min;
    Console.WriteLine($"Минимальный элемент = {min} ");
    Console.Write($"Разница между элементами массива: {max} - {min} =  {result} ");
}
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
arrayRandom(array);
differenceArray(array);
*/



/*Задать массив из 12 элементов, заполненных числами из [-9,9]. 
Найти сумму положительных/отрицательных элементов массива */

void arrayRandom(int[] array)
{
    Console.Write("Массив = ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void arraySum(int[] array)
{
    Console.Write("Положительные числа = ");
    int plus = 0;
    int minus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            plus = plus + array[i];
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
    Console.Write("Отрицательные числа = ");
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < 0)
        {
            minus = minus + array[j];
            Console.Write($"{array[j]} ");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"сумма положительных чисел = {plus}");
    Console.WriteLine($"сумма отрицательных чисел = {minus}");
}
int[] array = new int[12];
arrayRandom(array);
arraySum(array);

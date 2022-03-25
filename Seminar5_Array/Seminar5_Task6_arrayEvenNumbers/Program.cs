/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
void arrayRandom(int[] array)
{   
    Console.Write($"Массив заполненный случайными числами = ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}
void arrayEvenNumbers(int[] array)
{   
    Console.Write($"Массив чётных чисел = ");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (array[i] % 2 == 0) 
        {
            count = count + 1;
            Console.Write($"{array[i]} ");
        }
    }
        Console.WriteLine();
        Console.Write($"Количество чётных чисел в массиве {count} ");
}
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
arrayRandom(array);
arrayEvenNumbers(array);
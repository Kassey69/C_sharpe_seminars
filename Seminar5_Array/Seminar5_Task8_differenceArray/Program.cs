/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
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
    int temporary = 0;
    int min = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {      
        if (array[i] > max) 
        {
        max = array[i];
        }
        else temporary = array[i];
    }
        Console.WriteLine($"Максимальный элемент = {max} "); 
        min = temporary;
    for (int j = 0; j < array.Length; j++)
    {       
        if (array[j] < min) 
        {
        min = array[j];
        }
    }
        result = max - min;
        Console.WriteLine($"Минимальный элемент = {min} ");
        Console.Write($"Разницу между элементами массива: {max} - {min} =  {result} ");
}
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
arrayRandom(array);
differenceArray(array);
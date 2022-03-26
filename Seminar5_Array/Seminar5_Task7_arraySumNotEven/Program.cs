/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void arrayRandom(int[] array)
{   
    Console.Write($"Массив заполненный случайными числами = ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}
void arraySumNotEven(int[] array)
{   
    Console.Write($"Нужные нам элементы = ");
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
        Console.Write($"{array[i]} ");
    }    
        Console.WriteLine();
        Console.Write($"Cумма элементов, стоящих на нечётных позициях {sum} ");
}
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
arrayRandom(array);
arraySumNotEven(array);
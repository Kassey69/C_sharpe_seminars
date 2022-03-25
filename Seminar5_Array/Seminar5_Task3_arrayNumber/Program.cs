// Определить, присутствует ли в заданном массиве, некоторое число 
void arrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 6);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void arrayNumber(int[] array, int find)
{
    int count = 0;
    int tumbler = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
             // либо сделать обрывание break;
            Console.Write($"{array[i]} ");
            tumbler = 1; //переключатель, который мы передаем на выходе из условия цикла
            count = count + 1;
        }
    }
    Console.WriteLine();
    if (tumbler == 1) Console.Write($"число {find} найдено, таких чисел в числе {count} ");
    else Console.Write($"такого числа нет");
}
int[] array = new int[10];
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
arrayRandom(array);
arrayNumber(array, number);
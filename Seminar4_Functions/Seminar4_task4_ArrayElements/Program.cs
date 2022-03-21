/* 4 Задача. Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке. */
/*

void bitArray()
{
    int[] a = new int[8];

    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write(a[i] + " ");     
    }
}
bitArray();
*/
/*
void array()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write(a[i] + " ");
    }
}
array();
*/
void array()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i] + " ");
    }
}
array();
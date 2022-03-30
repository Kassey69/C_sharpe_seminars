/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
 Последовательность фибоначи 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 */ 

Console.WriteLine($"Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
array[0] = 0; 
array[1] = 1;
Console.Write($"0 1 ");
for (int i = 2; i < num; i++)
{
    array[i] = array[i - 1] + array[i - 2];
    Console.Write($"{array[i]} ");
}

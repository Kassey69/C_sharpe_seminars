/*Написать программу замену элементов массива на противоположные, переввернуть элементы массива по знаку
*/
//--  было 5  стало -5, было -6 стало 6
void arrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void arrayOpposite(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int result = 0;
        int s = -1;
        result = array[i] * s;
        Console.Write($"{result} ");  
    }
}
int[] array = new int[10];
arrayRandom(array);
arrayOpposite(array);
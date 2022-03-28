﻿/* Найти произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
ПАЛИНДРОМ СХОЖИЙ. 12345. НАЙТИ ПРОИЗВЕДЕНИЕ 1 И 5, 2 И 4 
И ЭТИ ЭЛЕМЕНТЫ НЕОБХОДИМО БУДЕТ ПОМЕЩАТЬ В НОВЫЙ МАССИВ 
ЕСЛИ МАССИВ БЫЛ НЕЧЕТНЫЙ. ЦЕНТРАЛЬНЫЙ ЭЛЕМЕНТ У КОГОТРОГО НЕТ ПАРЫ ОН В ТАКОМ ЖЕ ВИДЕ И ПЕРЕХОДИТ
ЕСЛИ МАССИВ ЧЕТНЫЙ ТО РЕЗУЛЬТАТ ЭТИХ ПАР БУДЕТ ПЕРЕХОДИТЬ В СЛЕДУЖЩИЙ МАССИВ
*/
void arrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]} ");
        // array[i] = i + 1;
        // Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void arrayPairsNumbers(int[] array)
{
    int dlina = 1;
    if (array.Length % 2 == 0) dlina = 0; // если количество в массиве четное, 
    // останотк при делении = 0, то тогда длина равна 0
    //если не четный то надо выделить на этот элемент 1 ячейку, это длина
    int[] array2 = new int[(array.Length / 2) + dlina]; //создаем втрой конечный массив для результата
    // выделяем память размер всего массива пололам, если массив 7 элементов то 7/2 = 3 и + еще 1 элемент длина
    for (int i = 0; i < array.Length / 2 + dlina; i++) // мы проходимся в цикле 
                                                      // по всем элементам уже итогового массива
// нам не надо весь массив проходить а по два элемента с начала и с конца, пожтому  он в 21 раз меньше                                                      
    {
        array2[i] = array[i] * (array[array.Length - 1 - i]); // array[^1] - последний эдемент также
        if (i == array.Length - 1 - i) array2[i] = array[i];
        // если  осевой элемент есть то записвываем значение
        // в текущий элемент итоговый массив записываем результат произведения 
        // соответствующего элемента иходного массива
        // и его партнера, а его партнер это последний элемент, зеркальный
        // array[array.Length - 1 - i] -- если у нас i = 0 , тоесть мы с нулевым элементом
        // имеем дело, то тогда второй элемент будет array[array.Length - 1]
        // - пояснение - Благодаря наличию свойства Length, мы можем вычислить 
        // индекс последнего элемента массива - это длина массива - 1. 
        // Например, если длина массива - 4 (то есть массив имеет 4 элемента), 
        // то индекс последнего элемента будет равен 3.
          Console.Write($"{array2[i]} ");
    }
}
Console.WriteLine("Введите длину массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
arrayRandom(array);
arrayPairsNumbers(array);


//if (n % 2 == 0) dlina = 0; //если число элементов в массиве четное, то тогда
//велечину на которую мы будем менять количество элементов мы приравниваем к нулю
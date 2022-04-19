// Есть два массива info и data. 
// В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 

// Напишите программу, которая составит массив десятичных представлений чисел массива data 
// с учетом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); 
// второе число занимает 3 бита(111 -> 7);
// третье число занимает 3 бита(000 -> 0);
// четвертое число зханимает 1 бит (1 -> 1)
// 111 перевести это будет (1*2)^2 + (1*2)^1 + 1 = 7

// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

Console.WriteLine($"Введите битный массив info");
int info = Convert.ToInt32(Console.ReadLine());
string ltr = info.ToString();
int[] infonew = new int[ltr.Length];
Console.Write($"массив info ");
for (int i = 0; i < ltr.Length; i++)
{
    infonew[i] = int.Parse(ltr[i].ToString());
    Console.Write($"{infonew[i]} ");
}
Console.WriteLine();

Console.WriteLine($"Введите двоичный массив data: вводите только нули и единицы");
//int data = Convert.ToInt32(Console.ReadLine());
int data = Convert.ToInt32(Console.ReadLine());
string str = data.ToString();
int[] datanew = new int[str.Length];
//Console.Write($"Двоичное число ");
for (int i = 0; i < str.Length; i++)
{
    if (str[i] != '0' && str[i] != '1') // str[i] != '0'
    {
        Console.Write($"Все цифры должны быть 0 и 1, попробуйте еще раз"); return;
    }
    else
    {
        //datanew[i] = Convert.ToInt32(str[i].ToString());
        datanew[i] = int.Parse(str[i].ToString());
        Console.Write($"{datanew[i]}{string.Empty} ");
    }
}
Console.WriteLine();

int[] array = data10Array(datanew, infonew);    // 2 = 2 и 1 элемент;  3 = 3 и 2 и 1 до 0
int[] data10Array(int[] datanew, int[] infonew)
{
    int[] resultArray = new int[infonew.Length];
    int PositionData = 0;
    Console.Write($"Двоичные числа: ");
    for (int i = 0; i < infonew.Length; i++)
    {
        string binary = "";
        int number = 0;
        for (int j = 0; j < infonew[i]; j++)  //2 = 2 и 1 элемент;  3 = 3 и 2 и 1 до 0 и все 4 так
        {
            number += datanew[PositionData + j] * (int)Math.Pow(2, infonew[i] - 1 - j);
             //c каждым числом увеличиваем степень
                    binary +=  Convert.ToString(datanew[PositionData + j] +"")  ;  
                                      //строчка переворачивается в зависимости где плюс                  
        }      
        Console.Write($"{binary} ");
        PositionData += infonew[i];
        resultArray[i] = number;
    }
      Console.WriteLine();
      Console.Write("Переводим в 10-е: [{0}]", string.Join(",", resultArray));
      return resultArray;  
}
/*
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }; // (0, 1) 1nd = 0*2^1 + 1*2^0; 
                                            // (1, 1, 1) 2nd = (1*2)^2 + (1*2)^1 + 1*2^0 = 7
int[] info = { 2, 3, 3, 1 };    // мы раскладываем каждый элемент на позиции i по j внутри элемента; 
int[] array = data10Array(data, info);    // 2 = 2 и 1 элемент;  3 = 3 и 2 и 1 до 0
int[] data10Array(int[] datanew, int[] infonew)
{
    int[] resultArray = new int[infonew.Length];
    int PositionData = 0;
    Console.Write($"Двоичные числа: ");
    for (int i = 0; i < infonew.Length; i++)
    {
        string binary = "";
        int number = 0;
        for (int j = 0; j < infonew[i]; j++)  //2 = 2 и 1 элемент;  3 = 3 и 2 и 1 до 0 и все 4 так
        {
            number += datanew[PositionData + j] * (int)Math.Pow(2, infonew[i] - 1 - j);
             //c каждым числом увеличиваем степень
                    binary +=  Convert.ToString(datanew[PositionData + j] +"")  ;  
                                      //строчка переворачивается в зависимости где плюс                  
        }      
        Console.Write($"{binary} ");
        PositionData += infonew[i];
        resultArray[i] = number;
    }
      Console.WriteLine();
      Console.Write("Переводим в 10-е: [{0}]", string.Join(",", resultArray));
      return resultArray;  
}
*/
// 75. Есть два массива info и data. 
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

// Console.WriteLine($"Введите количество бит");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
//     if (n == 3) (1*2)^2 + (1*2)^1 + 1 = 7
//     { 

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1,  };
int[] info = { 2, 3, 3, 1, 3 };
int[] array = data10Array(data,info);
int[] data10Array(int []databit, int []infonum)
{
    int [] arrayinfo = new int[infonum.Length];
    int DataPosition = 0;
        for (int i = 0; i < infonum.Length; i++)
        {     
            int num = 0;
            if(DataPosition + infonum[i] > databit.Length)
            {
                int cut = infonum[i] - databit.Length + DataPosition;
                while (DataPosition < databit.Length)
                {
                    num += databit[DataPosition] * (int)Math.Pow(2, databit.Length - 1 - DataPosition);
                    DataPosition++;
                }
                arrayinfo[i] = num;
                Console.Write(num + " ");
                Console.WriteLine();
                return arrayinfo;
            }    
            for (int k = 0; k < infonum[i]; k++)
            {
                num += databit[DataPosition + k] * (int)Math.Pow(2, infonum[i] - 1 - k);
            }
                Console.Write(num + " ");
                DataPosition += infonum[i];
        }
        return arrayinfo;
}

    



/*
Console.WriteLine($"Введите двоичное число");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();
int[] array = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int count = 0;
int sum = 0;
//int lastDigit = 0;
//int help = 0;
for (int i = 0; i < array.Length; i++)
{
    count++;
    //lastDigit = array[i];
}
// if (lastDigit % 2 == 0)
// {
//     help = 1;
// }
// Console.Write($"{lastDigit % 2} "); //проверка есть ли 0 на конце массива
for (int i = 0; i < array.Length; i++)
{
    //double result = Math.Pow(array[i]*2,count-i-1);
    //int result = Convert.ToInt32(Math.Pow(array[i] * 2, count - i - 1));
    111 перевести это будет (1*2)^2 + (1*2)^1 + 1 = 7
    sum += Convert.ToInt32(Convert.ToString(array[i])) * Convert.ToInt32(Math.Pow(2, (count - i - 1)));
    //sum = sum + result;
    // Console.Write($" {result} ");
}
Console.Write($" {sum} ");
//if (help == 1) Console.Write($" {sum } ");
// else
//     Console.Write($" {sum} ");
*/

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
        int pow = 0;
        for (int j = infonew[i]-1; j >=0; j--)  //2 = 2 и 1 элемент;  3 = 3 и 2 и 1 до 0 и все 4 так
        {
            number += datanew[PositionData + j] * (int)Math.Pow(2, pow);
            pow++;
             //c каждым числом увеличиваем степень
                    binary =  Convert.ToString(datanew[PositionData + j] +"") + binary ;  
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
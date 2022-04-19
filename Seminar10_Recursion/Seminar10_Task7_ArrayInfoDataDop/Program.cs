// Есть два массива info и data. 
// В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 

// Напишите программу, которая составит массив десятичных представлений чисел массива data 
// с учетом информации из массива info.

//Дополнить решение домашней задачи прошлого семинара, 
//добавив возможность ввода массивов info и data пользователем. 
//Проработать возможные частные случаи несоответствия данных в этих массивах.   
// int[] datanew = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }; 
// int[] infonew = { 2, 3, 3, 1 }; 

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

int[] array = data10Array(datanew, infonew);
int[] data10Array(int[] datanew, int[] infonew)
{
    int[] resultArray = new int[infonew.Length];
    int PositionData = 0;
    Console.Write($"Введенные двоичные числа: ");
    for (int i = 0; i < infonew.Length; i++)
    {
        string binary = "";
        int number = 0;
        if (PositionData + infonew[i] > datanew.Length)
        {
            int cut = infonew[i] - datanew.Length + PositionData;
            while (PositionData < datanew.Length)
            {
                number += datanew[PositionData] * (int)Math.Pow(2, datanew.Length - 1 - PositionData);
                PositionData++;
                binary+= Convert.ToString(datanew[PositionData + datanew.Length - 1 - PositionData ] + "") ;
            }
            Console.Write($"{binary} ");
            PositionData += infonew[i];
            resultArray[i] = number; 
            Console.WriteLine();
            Console.Write("Переводим в 10-е, пришлось добавить недостающие элементы: [{0}]", string.Join(",", resultArray)); 
            return resultArray;
            }
                for (int k = 0; k < infonew[i]; k++)
                {
                    number += datanew[PositionData + k] * (int)Math.Pow(2, infonew[i] - 1 - k);
                    binary+= Convert.ToString(datanew[PositionData + k] + "");
                }
                    Console.Write($"{binary} ");            
                    PositionData += infonew[i];
                    resultArray[i] = number; 
                }
                    Console.WriteLine();
                    Console.Write("Переводим в 10-е: [{0}]", string.Join(",", resultArray));       
                    return resultArray;
}


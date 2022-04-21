/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньшек либо равна 3 символа. Первоначальный массив можно ввести с клавеатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.

Примеры
["Hello", "2", "world", ":)"] -> ["2", ":)']
["1234", "1567", "-2", "computer sciense"] -> ["2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] data = { "Hello", "2", "world", ":)" };
string[] DataArray(string[] data)
{
    string[] resultArray = new string[0]; //Создаем новый пустой массив
    var realSize = 0; // индекс элементов нового массива
    int length; // длина нового массива
    for (int i = 0; i < data.Length; i++)
    {            
        if (data[i].Length <= 3) // ищет в массиве строки, длина которых меньшек либо равна 3 символа
        {          
            length = resultArray.Length;  //Мы используем Array.Resize для замены большого массива на меньший.
            Array.Resize(ref resultArray, length + 1); // ref передаем аргумент по ссылке     
            // соединяем составные части, в итоге формируем массив resultArray.Length                                        
            resultArray[realSize] = data[i]; //передаем значения найденных элементов из старого в новый массив
            realSize++;  //переходим к следующему элементу массива          
        }    
    }    
         return resultArray;
}
void PrintArray(string[] data, string[] resultArray)
{   
        Console.Write('[');
        Console.Write(string.Join($", ", data, 0, data.Length));
        Console.Write(']'+ " -> "+'[' );
        Console.Write(string.Join($", ", resultArray, 0, resultArray.Length)); //выдаем на монитор новый массив
        Console.Write(']');
}
PrintArray(data, DataArray(data)); //Вывод массива



// string[] data = { "Hello", "2", "world", ":)" };
// //string[] array = PrintDataArray(data);
// string[] PrintDataArray(string[] data)
// {
//     string[] resultArray = new string[data.Length];
//     var realSize = 0;
//     for (int i = 0; i < data.Length; i++)
//     {            
//             if (data[i].Length <= 3)
//             {
//                 resultArray[realSize] = data[i];
//                 realSize++;            
//             }    
//     }    
//         Console.Write('[');
//         Console.Write(string.Join($", ", data, 0, data.Length));
//         Console.Write(']'+ " -> "+'[' );
//         Console.Write(string.Join($", ", resultArray, 0, realSize));
//         Console.Write(']');
//         Console.Write($"\r\n");
//         //Console.Write("[{0}], ", string.Join(", ", (resultArray[i])); 
//          return resultArray;
// }
// PrintDataArray(data);







// Console.Clear();
// string[] arrayA = {"Hello", "2", "world", ":-)"};
// string[] Find(string[] arrayA)
// {
//     string[] arrayB = new string[0];
//     int j = 0;
//     for (int i = 0; i < arrayA.Length; i++)
//     {
//         if (arrayA[i].Length <= 3)
//         {
//             int length = arrayB.Length;
//             Array.Resize(ref arrayB, length + 1);
//             arrayB[j] = arrayA[i];
//             j++;

//         }

//     }
//     return (arrayB); 
// }
// void WriteArray(string[] arrayA, string[] arrayB)

// {
//     Console.Write("[");
//     for (int i = 0; i < arrayA.Length; i++)
//     {
//         Console.Write(arrayA[i]);
//         if (i != arrayA.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("] -> [");
//     for (int i = 0; i < arrayB.Length; i++)
//     {
//         Console.Write(arrayB[i]);
//         if (i != arrayB.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.WriteLine("]");
// }

// WriteArray(arrayA, Find(arrayA));

/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 
*/
void function(int num)
{
    if (num.ToString().Length < 3) // ToString() - переводит наше число в строчку
    {
        Console.WriteLine("3 цифры нет");
    }
    else
    {
        Console.WriteLine(num.ToString()[2]); //записывает наше число в строчку и отделяет 2 индекс элемента
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
function(number);
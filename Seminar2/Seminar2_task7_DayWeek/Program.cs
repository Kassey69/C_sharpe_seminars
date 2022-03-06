/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void function(int day)
{
    if(day<1 || day>7)
    {
        Console.WriteLine("Такого дня не существует");
    }
    else
    {
        if(day <=5)
        {
            Console.WriteLine("Будние дни");
            ;
        }
        if(day >5)
        {
            Console.WriteLine("Выходной");
            
        }
    }
}
Console.Write("Введите день недели от 1 до 7: ");
int days = Convert.ToInt32(Console.ReadLine());
function(days);
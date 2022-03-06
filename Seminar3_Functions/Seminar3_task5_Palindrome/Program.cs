/*Задача 19 Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void palindrome(int num)
{
    if (num.ToString().Length <= 4 || num.ToString().Length > 5) // ToString() - переводит наше число в строчку
        Console.WriteLine("5 цифр нет");
    else
    {
        if(num.ToString()[1] == num.ToString()[3] && num.ToString()[0] == num.ToString()[4])
        Console.WriteLine("Палиндром"); 
        else Console.WriteLine("Не Палиндром"); 
    }
}
Console.WriteLine("Введите 5-ти значное число");
int number = Convert.ToInt32(Console.ReadLine());
palindrome(number);

//ToString() - ReadLine() - пустые скобки означают что список аргументов пуст
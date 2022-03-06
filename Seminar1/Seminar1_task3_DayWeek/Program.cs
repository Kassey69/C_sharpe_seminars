// Задание 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
/*
Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7) //   (day < 1 || day > 7) -- это надо else переносить сразу с таким условием

{
    if (day == 7)
    {
    Console.WriteLine("Воскресенье");
    }

    if (day == 6)
    {
    Console.WriteLine("Суббота");
    }
    if (day == 5)
    {
    Console.WriteLine("Пятница");
    }
    if (day == 4)
    {
    Console.WriteLine("Четверг");
    }
    if (day == 3)
    {
    Console.WriteLine("Среда");
    }
    if (day == 2)
    {
    Console.WriteLine("Вторник");
    }
    if (day == 1)
    {
    Console.WriteLine("Понедельник");
    }
}
else
{

    Console.WriteLine("Нет такого дня");
}
*/


void dayweek(int day)
{
    if(day <1 || day > 7) Console.WriteLine("такого для недели не существует");     
    if(day == 1) Console.WriteLine("Понедельник");      
    if(day == 2) Console.WriteLine("Вторник");     
    if(day == 3) Console.WriteLine("Среда");      
    if(day == 4) Console.WriteLine("Четверг");     
    if(day == 5) Console.WriteLine("Пятница");       
    if(day == 6) Console.WriteLine("Суббота");   
    if(day == 7) Console.WriteLine("Воскресенье");  
}
Console.WriteLine("Введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());

dayweek(day);


/*
int dayweek(int day)
{
    if (day >= 1 && day <= 7)
    {
        if(day == 1)
        {
            Console.WriteLine("Понедельник");   
            return day;  
         }
        if(day == 2)
         {
            Console.WriteLine("Вторник");   
            return day;  
        }
        if(day == 3)
        {
            Console.WriteLine("Среда");   
            return day;   
        }
        if(day == 4)
        {
            Console.WriteLine("Четверг");   
            return day;  
        }
        if(day == 5)
        {
            Console.WriteLine("Пятница");   
            return day;    
        }
        if(day == 6)
        {
            Console.WriteLine("Суббота");
            return day;     
        }
        if(day == 7)
        {
            Console.WriteLine("Воскресенье");
            return day;
        }
    }
    else 
        Console.WriteLine("Такого дня недели нет");
        return day;   
}
Console.WriteLine("Введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());
dayweek(day);
*/


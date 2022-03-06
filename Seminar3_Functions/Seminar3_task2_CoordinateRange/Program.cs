/* Написать программу, которая принимает на вход номер четверти 
и выводит на экран диапазон координат, доступных в этой четверти
*/
/*
void ShowCoord(int quartNum)
{
    if (quartNum == 1)
        Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x > 0, y > 0");
    if (quartNum == 2)
        Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x < 0, y > 0");
    if (quartNum == 3)
        Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x < 0, y < 0");
    if (quartNum == 4)
        Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x > 0, y < 0");  
}
Console.Write("Введите номер четверти (целое число от 1 до 4): ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCoord(number);
*/
/*
int quarterNum(int num)
{
    if (num == 1)
    {
        Console.WriteLine("pointX > 0, pointY > 0"); return num;
    }
    if (num == 2)
    {
        Console.WriteLine("pointX < 0, pointY > 0"); return num;
    }
    if (num == 3)
    {
        Console.WriteLine("pointX < 0, pointY < 0"); return num;
    }
    if (num == 4)
    {
        Console.WriteLine("pointX > 0, pointY < 0"); return num;
    }
    else
    {
        Console.WriteLine("Неверно введена система координат"); return num;
    }
}
Console.WriteLine("Введите номер четверти");
int range = Convert.ToInt32(Console.ReadLine());
quarterNum(range);
*/
void quarterNum(int num)
{
    if (num == 1) Console.WriteLine("pointX > 0, pointY > 0");
    if (num == 2) Console.WriteLine("pointX < 0, pointY > 0");
    if (num == 3) Console.WriteLine("pointX < 0, pointY < 0");
    if (num == 4) Console.WriteLine("pointX > 0, pointY < 0"); 
    else Console.WriteLine("Неверно введена система координат");
}
Console.WriteLine("Введите номер четверти");
int range = Convert.ToInt32(Console.ReadLine());
quarterNum(range);


/* Написать программу, которая принимает на вход номер четверти 
и выводит на экран диапазон координат, доступных в этой четверти
та эже программа только через switch
*/
void ShowCoord(int quartNum)
{
    switch(quartNum)
    {
        case 1:
        {
            Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x > 0, y > 0");
            break;
        }
        case 2:
        {
             Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x < 0, y > 0");
             break;
        }
        case 3:
        {
        Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x < 0, y < 0");
        break;
        }
        case 4:
        {
            Console.WriteLine("В данной четверти координат могут быть в следующем диапазоне x > 0, y < 0");
            break;
        }
        default:
        {
            Console.WriteLine("Такой четверти не существует");
            break;
        }
    }
}
int number;
Console.Write("Введите номер четверти (целое число от 1 до 4): ");
number = Convert.ToInt32(Console.ReadLine());
ShowCoord(number);



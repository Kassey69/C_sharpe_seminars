//Задание 4. Написать программу которая на вход принимает одно число 
//а на выходе показывает все целые числа 
//в промежутке от минус этого числа до самого этого числа
// --- тоесть если пользователь вводит 3, то надо вывести на экран -3 -2 -1 0 1 2 3
/*Console.Write("Введите натуральное число "); // целое положительгное число 
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n * (-1);
while (neg_n <= n)
{
    Console.Write(neg_n+" ");
    neg_n++; // neg_n+=3 -- он будет прыгать через числа с шагом 3
}
*/
/*
void entrance(int num)
{
    int otrNum = (num*-1);
    while(otrNum <= num)
    {
        Console.Write(otrNum+" ");
        otrNum++;
    }
}
Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());

entrance(Num);
*/
int entrance(int num)
{
    int otrNum = (num * -1);
    while (otrNum <= num)
    {
        Console.Write(otrNum + " ");
        otrNum++;
    }
    return otrNum;
}
Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());

entrance(Num);
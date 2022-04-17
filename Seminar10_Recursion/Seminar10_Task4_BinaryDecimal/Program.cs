// Программа перевод чисел из двоичной системы счисления в десятичную

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
    int lastDigit = 0;
    int help = 0;
for (int i = 0; i < array.Length; i++)
{
    count++;
    lastDigit = array[i];
}
if (lastDigit % 2 == 0)
    {
         help = 1;
    }
    Console.Write($"{lastDigit  % 2 } "); //проверка есть ли 0 на конце массива
for (int i = 0; i < array.Length; i++)
{

    //sum += Convert.ToInt32(Convert.ToString(array[i])) * Convert.ToInt32(Math.Pow(2, (count - i - 1)));
    //double result = Math.Pow(array[i]*2,count-i-1);
    sum += Convert.ToInt32(Math.Pow(array[i]*2, count-i-1));
}
if (help == 1 ) Console.Write($" {sum-1} ");
else
Console.Write($" {sum} ");

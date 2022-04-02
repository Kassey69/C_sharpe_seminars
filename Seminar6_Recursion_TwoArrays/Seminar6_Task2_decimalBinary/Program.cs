/*десятичное число в двоичную форму реализовать через массив
Двоичная система счисления — это позиционная система счисления с основанием 2. 
В этой системе счисления натуральные числа записываются с помощью всего 
лишь двух символов (в роли которых обычно выступают цифры 0 и 1).
обычная это десятичная */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
string a = ""; //информация которая записывается в число можно преобразовать в строку;
for (int i = 0; i < array.Length; i++)
{
    if (number <= 0) break;
    else
    {
        a = Convert.ToString(number % 2) + a; // в страку, в ее начало, 
        //записывается остаток от деления на 2
         // важно в какой последовательности слогаемые указаны, так от 56 получится 111000              
        //если (a) сначала сложить = a + Convert.ToString(number % 2) , то результат будет 000111
        // array[i] = number % 2;
        number = number / 2;
        //Console.Write(array[i] );
    }
}
Console.Write(a);

// Второй пособ
/*
void method(int num)
{
    string result = "";
    while (num > 0)
    {
        result = Convert.ToString(num % 2) + result;
        num = num / 2;
    }
    Console.WriteLine(result);
}
Console.WriteLine($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());
method(number);
*/


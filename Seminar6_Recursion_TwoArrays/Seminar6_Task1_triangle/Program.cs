/*Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
A < B + C  каждое число длина стороны */
void triangle(int a, int b, int c)
{
    // bool flag = true;
    // if (arg1 >= arg2 + arg3) Console.WriteLine()
    if (a < b + c && b < a + c && c < a + b)
         Console.WriteLine($"Условие выполняется, треугольник существует");
    else Console.WriteLine($"Условие не выполняется");
}
Console.WriteLine("Введите n1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n3 число");
int number3 = Convert.ToInt32(Console.ReadLine());
triangle(number1, number2, number3);







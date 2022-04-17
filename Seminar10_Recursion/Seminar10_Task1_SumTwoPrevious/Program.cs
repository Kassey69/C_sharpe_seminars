// Задача 1. Написать программу которая на вход примет 2 часла
// и выдаст первое n чисел, для которых каждое следующее равно сумме двух предыдущих

// 73. Написать программу показывающие первые N чисел, для которых каждое следующее 
// равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int SumTwoPrevious(int startNum1, int startNum2, int size)
{
    if (size == 1) return startNum1;
    if (size == 2) return startNum2;
    else return SumTwoPrevious(startNum1, startNum2, size - 1) + SumTwoPrevious(startNum1, startNum2, size - 2);
}
int num1 = 0,
    num2 = 1,
    col = 10;
for (int i = 1; i <= col; i++)
{
    Console.Write($"{SumTwoPrevious(num1, num2, i)} ");
}




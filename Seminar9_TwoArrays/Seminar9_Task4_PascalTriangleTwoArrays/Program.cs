


int[,] CreateTriangle(int n)
{
    int[,] triangle = new int[n, n];
    for (int i = 0; i < n; i++) // тут j второй for не нужен. потому что size и там и там, за обоих
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < n; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }
    }
    //printTriangle(triangle);
    return triangle;
}
//CreateTriangle(10);
void printTriangle(int[,] triangle)
{
    Console.WriteLine();
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j <= (triangle.GetLength(0) - i); j++) //сщздаем после каждой строки 
                // n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Console.Write("  ");
        }
        for (int j = 0; j <= i; j++) // (j = i) тут проявляются правые единицы
        {
            Console.Write(" "); // Создает пробелы между элементами треугольника
            if (CreateTriangle(triangle.GetLength(0))[i, j] < 10)
            {
                Console.Write(" " + CreateTriangle(triangle.GetLength(0))[i, j] + " ");
            }
            if (CreateTriangle(triangle.GetLength(0))[i, j] >= 10 && (CreateTriangle(triangle.GetLength(0))[i, j]) < 100)
            {
                Console.Write(CreateTriangle(triangle.GetLength(0))[i, j] + " ");
            }
            if (CreateTriangle(triangle.GetLength(0))[i, j] >= 100)
            {
                Console.Write(CreateTriangle(triangle.GetLength(0))[i, j]);
            }
        }
        Console.WriteLine(); 
        Console.WriteLine(); //после каждой строки с числами отступаем две пустые строчки
    }
}
Console.WriteLine($"Введите длину треуголника");
int n = Convert.ToInt32(Console.ReadLine());
int[,] triangle = CreateTriangle(n);
printTriangle(triangle);

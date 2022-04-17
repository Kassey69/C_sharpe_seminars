// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)
//--------------------------------------------------------------
// Сделатиь случайную генерацию!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//--------------------------------------------------------------
/*
int n = 2; int m = 2; int h = 2;
int[,,] matrix = new int[n, m, h];
int step = 10;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < h; k++)
        {
            matrix[i, j, k] = step++;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < h; k++)
        {
            Console.Write($"{matrix[i, j, k]} ({i} {j} {k}) ");
        }
        Console.WriteLine();
    }
}
*/

int[,,] CreateMatrix3D(int height, int width, int depth)
{
    int[,,] matrix3D = new int[height, width, depth];
    int[] rndGen = new int[height * width * depth];

    for (int i = 0; i < height * width * depth; i++)
    {
        do //ЦИКЛ БУДЕТ РАБОТАТЬ ДО ТЕХ ПОР пока значение текущего элемента не возвращает в 1
        {
            rndGen[i] = new Random().Next(10, 100);
            for (int j = 0; j < i; j++) //проверка а нет ли такого числа в одномерном массиве
            {
                if (rndGen[i] == rndGen[j]) rndGen[i] = 1; // если хотя бы одно повторение обнаружено
                break;                                    // присваиваем 1
            }
        } while (rndGen[i] == 1); // было обнаружено повторение элемента массива
    }
    int n = 0;
    for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            for (int k = 0; k < depth; k++)
                matrix3D[i, j, k] = rndGen[n++]; // заполняется трезмерный массив

    return matrix3D;
}

void PrintMatrix3D(int[,,] matr3D)
{
    Console.WriteLine("Matrix of " + matr3D.GetLength(0) +
                             " x " + matr3D.GetLength(1) +
                             " x " + matr3D.GetLength(2));

for (int i = 0; i < matr3D.GetLength(0); i++)
    for (int j = 0; j < matr3D.GetLength(1); j++)
    {
        for (int k = 0; k < matr3D.GetLength(2); k++)
            Console.Write($"{matr3D[i, j, k]} ({i} {j} {k}) ");
        Console.WriteLine();
    }
Console.WriteLine();
}
int height = 2; int width = 2; int depth = 2;
int[,,] matrix3D = CreateMatrix3D(height, width, depth);
PrintMatrix3D(matrix3D);
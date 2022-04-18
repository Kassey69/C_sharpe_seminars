//Удалить ряд где есть 0
Console.WriteLine("Введите размерность двумерного массива: ");
Console.Write("Строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[n, m];
for (int g = 0; g < n; g++) //ЗДЕСЬ ВЫДАЕТ ОШИБКУ
{
for (int j = 0; j < m; j++)
{
array[g, j] = new Random().Next(0, 10);
Console.Write(array[g, j] + "\t");//Создание двумерного массива
}
Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
int i = 0;
int f = 0;
while (i <= n)
{
int a = 0;
for (int j = 0; j < m; j++)

if (array[i, j] == 0)

a = 1;
if (a == 1) //если в строке есть 0
{
f = 1; //фиксируем
for (int k = 0; k < m; k++)//элементы всех строк
for (int l = i; l < n - 1; l++)//от последней до следующей за найденной
array[l, k] = array[l + 1, k];//поднимаем на 1 вверх
n = n - 1;//уменьшаем количество строк
}
else
i += 1;

}
if (f == 0)
Console.Write("НЕТ НУЛЕЙ");
if (n == 0)
Console.Write("Все строки удалены");
else
{
Console.WriteLine("Строки с нулями удалены: ");
for (int z = 0; z < n; z++)//ЗДЕСЬ ВЫДАЕТ ОШИБКУ
{
for (int j = 0; j < m; j++)
{
Console.Write(array[z, j] + "\t");
}
Console.WriteLine();
}
}
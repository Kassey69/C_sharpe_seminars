/*1. Записать метод принимающий на вход координаты точки в двумерной 
плоскости и определяющей в какой четверти эта точка будет находиться
*/

int GetQuart(double xPoint, double yPoint)
{   
    if (xPoint > 0 && yPoint > 0) return 1; // когда в теле условия 1 действия фигурные скобки ненужны
    if (xPoint < 0 && yPoint > 0) return 2;
    if (xPoint < 0 && yPoint < 0) return 3;
    if (xPoint > 0 && yPoint < 0) return 4;
    return 0;   //else return 0;
}
Console.Write("Input x ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y ");
double y = Convert.ToDouble(Console.ReadLine());
int quartNum = GetQuart(x,y);
if(quartNum == 0) Console.WriteLine("Нельзя однозначно определить четверть");
// когда в теле условия 1 действия фигурные скобки ненужны
else Console.WriteLine("Данная точка находится в "+ quartNum + "четверти");

/*
void point(int pointX, int pointY)
{
    if (pointX > 0 && pointY > 0) Console.WriteLine("1 четверть");
    if (pointX < 0 && pointY > 0) Console.WriteLine("2 четвеврть");
    if (pointX < 0 && pointY < 0) Console.WriteLine("3 четвеврть");
    if (pointX > 0 && pointY < 0) Console.WriteLine("4 четвеврть");
    if (pointX == 0 || pointY == 0) Console.WriteLine("Нельзя однозначно определить четверть");
}
Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
point(x, y);
*/
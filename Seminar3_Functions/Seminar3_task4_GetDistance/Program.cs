/*Написать программу, принимающую на вход координаты двух точек 
и определяющую расстояние между ними
*/


double GetDistance(double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2));
}
//double xA, yA, xB, yB;
//double distance;

Console.Write("Input X of point A:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B:");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(GetDistance(xA,yA,xB,yB));

/*distance = GetDistance(xA,yA,xB,yB);
Console.WriteLine(distance);*/

/*
void distance(double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double Result = Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2));
    Console.WriteLine(Result);
}
Console.WriteLine("Введите xA");
double xA = Convert.ToInt32(Console.ReadLine()); //x1
Console.WriteLine("Введите yA");
double yA = Convert.ToInt32(Console.ReadLine()); //y1
Console.WriteLine("Введите xB");
double xB = Convert.ToInt32(Console.ReadLine()); //x2
Console.WriteLine("Введите yB");
double yB = Convert.ToInt32(Console.ReadLine()); //y2
distance(xA,yA,xB,yB);
*/
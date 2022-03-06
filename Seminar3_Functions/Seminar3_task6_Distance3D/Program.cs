/*Задача 21. Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
void distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;
    double Result = Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2)+Math.Pow(zDistance,2));
    Console.WriteLine("Координаты точек"+Result);
}
Console.WriteLine("Введите Ax");
double Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Ay");
double Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Az");
double Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Bx");
double Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите By");
double By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Bz");
double Bz = Convert.ToInt32(Console.ReadLine());
distance(Ax,Ay,Az,Bx,By,Bz);
*/
double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;
    double Result = Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2)+Math.Pow(zDistance,2));
    Console.WriteLine("Координаты точек"+Result);
    return Result;
}
Console.WriteLine("Введите Ax");
double Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Ay");
double Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Az");
double Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Bx");
double Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите By");
double By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Bz");
double Bz = Convert.ToInt32(Console.ReadLine());
distance(Ax,Ay,Az,Bx,By,Bz);
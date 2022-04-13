// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


string Rpint(double b1, double k1, double b2, double k2)
{
    double xPeres = (b1 - b2) / (k1 - k2);
    double yPeres = k1 * xPeres + b1;
    string result = xPeres + ";" + yPeres;
    return result;
    //return (xPeres,yPeres); вот так делаются несколько элементов, в скобках
}
int b1 = 2,
    k1 = 5,
    b2 = 4,
    k2 = 9;
Console.WriteLine($"{Rpint(b1, k1, b2, k2)}");
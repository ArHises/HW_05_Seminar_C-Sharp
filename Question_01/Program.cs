// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы Написать программу масштабирования фигуры.

Random ran = new Random();

double k1 = ran.Next(-10,10);
double k2 = ran.Next(-10,10);

double b1 = ran.Next(-10,10);
double b2 = ran.Next(-10,10);

Console.WriteLine($"y1 = {k1}x +({b1})");// y1 = k1 * x + b1
Console.WriteLine($"y2 = {k2}x +({b2})");// y2 = k2 * x + b2

if(k1 - k2 != 0) {
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"The point is: ({x},{y})");
}
else Console.WriteLine("LOL no point");// Параллельный(



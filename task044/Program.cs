/* Найти точку пересечения двух прямых, заданных уравнением 
 y = k1 * x + b1,      y = k2 * x + b2,            b1 k1 и b2 и k2 заданы
Решение: 
1. приравниваем правые части данных равенств, потому что они обе равны y:
        k1*x+b1=k2*x+b2,  выразим отсюда x: x=(b2-b1)/(k1-k2)
    затем подставим полученное значение х в выражение для у (для любого, например первого) :
        y=k1(b2-b1)/(k1-k2)+b1
2. Ответ: 
        x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1      */

Console.Clear();

Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine($"Точка пересечения двух прямых X = {x:0.000} , Y = {y:0.000}\n");


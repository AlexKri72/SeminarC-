// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();

int z = 0; //номер координатной плоскости
Console.Write("Введите координату x : ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату y : ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) z = 1;
if (x < 0 && y > 0) z = 2;
if (x < 0 && y < 0) z = 3;
if (x > 0 && y < 0) z = 4;
if (x == 0 || y == 0) Console.WriteLine("Ошибка, по условию координаты не могут быть равны нулю!");

Console.WriteLine($"Заданная точка принадлежит {z} координатной плоскости.");

Console.WriteLine();

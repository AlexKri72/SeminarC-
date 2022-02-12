// Выяснить являются ли три числа сторонами треугольника
// Решение: неравенство треугольника: если есть три числа a,b,c, 
// то они являются сторонами треугольника если (a+b) > c и (b+c) > a и (a+c) > b

Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if ((a + b) > c && (b + c) > a && (a + c) > b) Console.WriteLine("Заданные числа являются сторонами треугольника.");
else Console.WriteLine("Заданные числа НЕ МОГУТ быть сторонами треугольника.");

Console.WriteLine();

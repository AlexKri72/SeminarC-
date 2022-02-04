// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

Console.Write($"Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a == b * b || b == a * a) Console.WriteLine("Одно из чисел является квадратом другого!");
else Console.WriteLine("Числа не являются квадратами друг друга!");

Console.WriteLine();
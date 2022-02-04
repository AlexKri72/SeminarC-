// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();

int a = new Random().Next(10, 100);
Console.WriteLine($"Задано число: {a}");
int b = a % 10;
int c = a / 10;

if (b > c) Console.WriteLine($"Наибольшая цифра в числе : {b}");
else Console.WriteLine($"Наибольшая цифра в числе : {c}");

Console.WriteLine();


// Возведите число А в натуральную степень B используя цикл

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("В какую степень будем возводить? : ");
int b = int.Parse(Console.ReadLine());
int degree = a;
for (int i = 2; i <= b ; i++) degree *= a;

Console.WriteLine($"{a} в степени {b} равно: {degree}");

Console.WriteLine();

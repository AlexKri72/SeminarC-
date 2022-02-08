// Показать таблицу квадратов чисел от 1 до N

Console.Clear();

int a = new Random().Next(1, 25);
Console.WriteLine("\t Число  \t Квадрат числа");
for (int i = 1; i <= a; i++) Console.WriteLine($"\t {i}  \t\t {(i * i)}");

Console.WriteLine();

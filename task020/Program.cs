// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

Console.Write("Введите номер координатной плоскости:  ");
int plane = int.Parse(Console.ReadLine());
Console.WriteLine("\t \t \t Min \t \t \t Max");
if (plane == 1 || plane == 4)   Console.WriteLine($"X: \t \t \t 0 \t \t {int.MaxValue} ");
if (plane == 2 || plane == 3)   Console.WriteLine($"X: \t \t \t {int.MinValue} \t \t 0 ");
if (plane == 1 || plane == 2)   Console.WriteLine($"Y: \t \t \t 0 \t \t {int.MaxValue} ");
if (plane == 4 || plane == 3)   Console.WriteLine($"Y: \t \t \t {int.MinValue} \t \t 0 ");
else Console.WriteLine("Ошибка, такой координатной плоскости не существует!");

Console.WriteLine();

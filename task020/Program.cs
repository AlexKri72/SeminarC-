// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

Console.Write("Введите номер координатной плоскости:  ");
int plane = int.Parse(Console.ReadLine());
Console.WriteLine("\t Min \t \t Max");
// выводятся возможные диапазоны для ЦЕЛОЧИСЛЕННЫХ координат!
if (plane == 1 || plane == 4) Console.WriteLine($"X: \t 0 \t \t {int.MaxValue} ");
if (plane == 2 || plane == 3) Console.WriteLine($"X: \t {int.MinValue} \t \t 0 ");
if (plane == 1 || plane == 2) Console.WriteLine($"Y: \t 0 \t \t {int.MaxValue} ");
if (plane == 4 || plane == 3) Console.WriteLine($"Y: \t {int.MinValue} \t \t 0 ");
if (plane < 1 && plane > 4) Console.WriteLine("Ошибка, такой координатной плоскости не существует!");

Console.WriteLine();

// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();

Console.Write("Введите максимальную цифру диапазона от 1 до : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("\t Число \t \t Куб числа, заканчивающегося на чётную цифру");
for (int i = 1; i <= n; i++)
    if (i % 2 == 0 && i % 10 != 0) Console.WriteLine($"\t {i} \t \t {i * i * i}");

Console.WriteLine();

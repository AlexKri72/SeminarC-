// Определить количество цифр в числе

Console.Clear();

Console.Write("Задайте любое целое число: ");
int a = int.Parse(Console.ReadLine());
string b = Convert.ToString(a);
Console.WriteLine($"Количество цифр в заданном числе равно: {b.Length}");

Console.WriteLine();

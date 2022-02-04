// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Clear();
int a = 3;
Console.Write("Введите число: ");
int b = int.Parse (Console.ReadLine());
if (b%a == 0) Console.WriteLine("Число кратно трем");
else Console.WriteLine($"Число не кратно трем, остаток равен {b%a}");

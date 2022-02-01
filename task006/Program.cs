// Выяснить, является ли число чётным

Console.Clear();
int n = new Random().Next(1, 101);
Console.WriteLine("Подобрано число: " + n);
if (n % 2 == 0)
{
    Console.WriteLine("Это чётное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
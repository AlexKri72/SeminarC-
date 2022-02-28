// Рекурсия: Показать натуральные числа от M до N, N и M заданы

Console.Clear();
Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m:d2} ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m:d2} ");
        NaturalNumber(m - 1, n);
    }
    if (m == n) Console.Write($"{m:d2} ");
}
NaturalNumber(m, n);


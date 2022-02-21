// Рекурсия: Показать натуральные числа от M до N, N и M заданы

Console.Clear();
Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());
if (m > n)
{
    int temp = n;
    n = m;
    m = temp;
}

int NaturalNumber(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m:d2} ");
        m++;
        NaturalNumber(m, n);
    }
    return m;
}
NaturalNumber(m, n);


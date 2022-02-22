// Рекурсия: Найти сумму элементов от M до N, N и M заданы

Console.Clear();

Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
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
        sum += m;
        m++;
        NaturalNumber(m, n);
    }
    return m;
}
NaturalNumber(m, n);
Console.WriteLine($"\nСумма элементов равна: {sum:n0}\n");



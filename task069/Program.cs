// Рекурсия: Найти сумму элементов от M до N, N и M заданы

Console.Clear();

Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int NaturalNumber(int m, int n)
{
    if (m < n)
    {
        sum += m;
        NaturalNumber(m + 1, n);
        return sum + n;
    }
    else if (m > n)
    {
        sum += n;
        NaturalNumber(m, n + 1);
        return sum + m;
    }
    else return 0;
}
Console.WriteLine($"\nСумма элементов равна: {NaturalNumber(m, n):n0}\n");



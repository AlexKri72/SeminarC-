// Рекурсия: Найти сумму цифр числа

Console.Clear();

Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int Counter(int n)
{
    if (n % 10 > 0)
    {
        sum += n % 10;
        n /= 10;
        Counter(n);
    }
    return n;
}
Counter(n);
Console.WriteLine("Сумма цифр заданного числа равна: " + sum);

Console.WriteLine();

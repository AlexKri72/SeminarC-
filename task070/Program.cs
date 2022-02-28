// Рекурсия: Найти сумму цифр числа

Console.Clear();

Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());

int Summa(int n)
{
    if (n > 0) return n % 10 + Summa(n / 10);
    else return 0;
}

Console.WriteLine("Сумма цифр заданного числа равна: " + Summa(n));


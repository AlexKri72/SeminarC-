// Рекурсия: Показать натуральные числа от N до 1, N задано

Console.Clear();

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());

int NaturalNumber(int num)
{
    num--;
    if (num != 0)
    {
        Console.Write($"{num:d2} ");
        NaturalNumber(num);
    }
    return num;
}
NaturalNumber(n + 1);


// Подсчитать сумму цифр в числе

Console.Clear();

int a = new Random().Next(11,1000000);
Console.WriteLine($"Задано случайное число: {a}");
int sum = 0;
while (a > 0)
{
    sum += a % 10;
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в заданном числе равна: {sum}");

Console.WriteLine();

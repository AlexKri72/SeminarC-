// Найти сумму чисел от 1 до А
Console.Clear();

int sum = 0;
int a = new Random().Next(1, 25);
for (int i = 1; i <= a; i++) sum += i;

Console.WriteLine($"Задано случайное число : {a}");
Console.WriteLine($"Сумма от 1 до {a} равна: {sum}");

Console.WriteLine();
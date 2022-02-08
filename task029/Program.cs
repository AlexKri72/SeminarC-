// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

int composition = 1;
int a = new Random().Next(1, 20);
for (int i = 1; i <= a; i++) composition *= i;

Console.WriteLine($"Задано случайное число : {a}");
Console.WriteLine($"Произведение цифр от 1 до {a} равно: {composition}");

Console.WriteLine();

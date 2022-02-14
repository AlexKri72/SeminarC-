// Написать программу преобразования десятичного числа в двоичное
// Решение: поскольку в задании не указано каким образом нужно его решать (можно было бы через деление на 2),
// то будем решать двумя методами.

Console.Clear();

int a = new Random().Next(100, 10001);
int b = a;
string binaryCode = Convert.ToString(a, 2);
Console.WriteLine($"Решение первым методом: \nЗадано случайное число: {a}, в двоичном коде оно равно: {binaryCode}");

Console.Write($"\nРешение вторым методом: \nЗадано случайное число: {b}, в двоичном коде оно равно: ");
int remainder;
string result = string.Empty;
while (b > 0)
{
    remainder = b % 2;
    b /= 2;
    result = remainder.ToString() + result;
}
Console.WriteLine(result + "\n");

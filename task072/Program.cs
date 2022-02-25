// Рекурсия: Написать программу возведения числа А в целую степень B

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("В какую степень будем возводить? : ");
int b = int.Parse(Console.ReadLine());

int Pow(int a, int pow)
{
    if (pow == 0) return 1;
    if (pow > 0) return Pow(a, pow - 1) * a;
    return 1 / Pow(a, -pow);
}

Console.WriteLine($"\n{a} в степени {b} равно: {Pow(a, b)}\n");

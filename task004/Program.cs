// Найти максимальное из трех чисел
Console.Clear ();
int a = new Random().Next(1,101);
int b = new Random().Next(1,101);
int c = new Random().Next(1,101);
int max = a;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine("Первое число: " + a);
Console.WriteLine("Второе число: " + b);
Console.WriteLine("Третье число: " + c);
Console.WriteLine("Максимальное число: " + max);

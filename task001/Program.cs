// По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();
Console.Write("Введите первое число: ");
int n1 = int.Parse (Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse (Console.ReadLine());
if (n1==n2*2)
{
    Console.WriteLine("Это квадрат");
}
else
{
    Console.WriteLine("Это не квадрат");
}


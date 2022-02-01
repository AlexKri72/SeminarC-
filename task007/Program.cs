// Показать числа от -N до N
Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = n;
n = n - 2 * n;
while (n <= count)
{
    Console.Write(n + " ");
    n++;
}
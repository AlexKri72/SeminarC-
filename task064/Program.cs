// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.Clear();

int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
        x *= i;
    return x;
}

int i, n, c;
Console.Write("Введите нужное количество строк треугольника Паскаля: ");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++)  // создаём после каждой строки n-i отступов от левой стороны консоли,чем ниже строка, тем меньше отсутп
        Console.Write("   ");
        
    for (c = 0; c <= i; c++)
    {
        int element = factorial(i) / (factorial(c) * factorial(i - c)); //получаем элемент строки треугольника  
        Console.Write("{0}",element + "     ");
    }
    Console.WriteLine();
}
Console.WriteLine();

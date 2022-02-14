// Показать числа Фибоначчи

Console.Clear();

Console.Write("Сколько чисел из ряда Фибоначчи,но не более 46, будем считать ? ");
int count = int.Parse(Console.ReadLine());
int first = 1;
int second = 1;
Console.Write(" " + first);
Console.Write(" " + second);
int sum = 0;
for (int i = 0; i < count - 2; i++)
{
    sum = first + second;
    Console.Write(" " + sum);
    first = second;
    second = sum;
}
Console.WriteLine("\n");

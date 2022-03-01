// Рекурсия : Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.Clear();


Console.Write("Введите первое число: ");
int numFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = int.Parse(Console.ReadLine());
Console.Write("Сколько чисел будем складывать?: ");
int count = int.Parse(Console.ReadLine());

int Summa(int a, int b, int count)
{
    if (count == 1) return a;
    if (count == 2) return b;
    else
    {
        int sum = Summa(a, b, count - 1) + Summa(a, b, count - 2);
        return sum;
    }
}
for (int i = 1; i <= count; i++)
{
    Console.Write(Summa(numFirst, numSecond, i) +"  ");    
}
Console.WriteLine("\n");

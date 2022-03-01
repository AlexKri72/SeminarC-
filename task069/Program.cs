/* Рекурсия: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
M = 1; N = 4 -> 10
M = 4; N = 8. -> 30                  */

Console.Clear();

Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int NaturalNumber(int m, int n)
{
    if (m < n)
    {
        sum += m;
        NaturalNumber(m + 1, n);
        return sum + n;
    }
    else if (m > n)
    {
        sum += n;
        NaturalNumber(m, n + 1);
        return sum + m;
    }
    else return 0;
}
Console.WriteLine($"\nСумма элементов равна: {NaturalNumber(m, n):n0}\n");



/* Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, 
так чтобы в одной группе все числа были взаимно просты.
Например для N = 50, M получается 6
Одно из решений :
Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48
Ещё одно решение:
Группа 1: 1 
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 16 24 36 40 
Группа 6: 32 48
Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰  */

Console.Clear();

static int CalculateGroupsNumber(int n)
{
    int groupsNumber = (int)Math.Ceiling(Math.Log(n, 2));
    if ((int)Math.Pow(2, groupsNumber) == n) groupsNumber++;
    return groupsNumber;
}
int[] GetNextGroup(int groupNumber, int groupsQuantity, int n)
{
    if (groupNumber != groupsQuantity)
        return Enumerable.Range((int)Math.Pow(2, groupNumber - 1)
                , (int)Math.Pow(2, groupNumber) - (int)Math.Pow(2, groupNumber - 1)).ToArray();
    else
        return Enumerable.Range((int)Math.Pow(2, groupNumber - 1)
                , n - (int)Math.Pow(2, groupNumber - 1) + 1).ToArray();
}
void Main()
{
    int n = 0;
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine());
    while (n <= 0)
    {
        Console.WriteLine("Ошибка: число должно быть положительным!");
        Console.Write("Повторите ввод: ");
        n = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Количество групп для разбиения: {CalculateGroupsNumber(n)}");
    for (int i = 1; i <= CalculateGroupsNumber(n); i++)
        Console.WriteLine($"{i}-я группа: {String.Join(", ", GetNextGroup(i, CalculateGroupsNumber(n), n))}");
}
Main();

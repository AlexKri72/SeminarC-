// В матрице чисел найти сумму элементов главной диагонали

Console.Clear();

Console.Write("Задайте размерность матрицы: ");
int m = int.Parse(Console.ReadLine());

int[,] array = new int[m, m];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 501);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    sum += array[i,i];
}
Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");
Console.WriteLine();

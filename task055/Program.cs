// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

Console.Write("Задайте количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

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

Console.WriteLine("Сумма столбцов: ");

for (int i = 0; i < array.GetLength(1); i++)
{
    int sum =0;
    for (int j = 0; j < array.GetLength(0); j++) sum += array[j,i];
    Console.Write($"{sum} \t");
}

Console.WriteLine();

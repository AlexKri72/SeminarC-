// В двумерном массиве n×k заменить четные элементы на противоположные

Console.Clear();

Console.Write("Задайте количество строк в массиве: ");
int n= int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int k = int.Parse(Console.ReadLine());

int[,] array = new int[n, k];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-500, 501);
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

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] % 2 == 0 ) array[i,j] -= array[i,j]*2;
    }
}
Console.WriteLine("Изменённый массив:");
PrintArray(array);
Console.WriteLine();

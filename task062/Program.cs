// В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
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
int[,] DeleteRow(int[,] array, int row)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != row)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[x, j] = array[i, j];
            }
        }
        else continue;
        x++;
    }
    return result;
}
int[,] DeleteColumn(int[,] array, int column)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int x = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != column) 
            {
                result[i, x] = array[i, j];
            }
            else continue;
            x++;
        }
    }
    return result;
}
FillArray(array);
PrintArray(array);

int min = array[0, 0];
int MinIndexRow = 0;
int MinIndexColumn = 0;

for (int i = 0; i < array.GetLength(0); i++) //ищем минимальное значение в массиве и его индексы
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            MinIndexRow = i;
            MinIndexColumn = j;
        }
    }
}

Console.WriteLine($"Минимальное число {min} , индекс строки {MinIndexRow} , индекс столбца {MinIndexColumn}\n");
int[,] arrayDeleteRow = DeleteRow(array, MinIndexRow);
int[,] arrayDeleteRowAndColumn = DeleteColumn(arrayDeleteRow, MinIndexColumn);
Console.WriteLine("Массив с удалённой строкой и столбцом: \n");
PrintArray(arrayDeleteRowAndColumn);
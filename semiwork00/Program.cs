// Самостоятельная тренировка
Console.Clear();

void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(1, 101);
        index++;
    }
}

void PrintMassive(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write($"{array[index]}  ");
        index++;
    }
}

int[] massive = new int[50];
FillArray(massive);
PrintMassive(massive);

Console.WriteLine();
Console.WriteLine();


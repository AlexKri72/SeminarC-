// Написать программу замену элементов массива на противоположные

Console.Clear();

int[] array = new int[12];
void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(-9, 10);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} \t ");
}
FillArray(array);
Console.Write($"Первоначально заданный массив чисел: \n");
PrintArray(array);


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) array[i] -= array[i] * 2;
    else array[i] -= array[i] * 2;
}

Console.Write($"\nИнвертированный массив чисел: \n");
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

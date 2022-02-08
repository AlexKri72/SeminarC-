// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();

int[] array = new int[8];
void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(0, 2);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}  ");
}
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine();
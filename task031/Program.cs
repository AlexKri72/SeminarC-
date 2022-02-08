// Задать массив из 8 элементов и вывести их на экран

Console.Clear();

int[] array = new int[8] {34,56,2,72,8,56,7,16};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

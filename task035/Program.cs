// Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();

int[] array = new int[20];
void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(-500, 501);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} \t ");
}
// закончились методы, началось тело программы

FillArray(array);
PrintArray(array);
Console.Write("\nКакое число ищем? : ");
int a = int.Parse(Console.ReadLine());

int b = Array.IndexOf(array, a);
if (b == -1) Console.WriteLine("Данное число отсутствует в массиве!");
else Console.WriteLine($"Данный элемент находится на {b + 1} позиции массива");

Console.WriteLine();
Console.WriteLine();

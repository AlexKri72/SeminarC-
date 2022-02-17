// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] array = new double[5];

void FillArray(double[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(1, 1000) + new Random().NextDouble();
}
void PrintArray(double[] massive)
{
    Console.WriteLine("\t Номер позиции \tЭлемент массива");
    for (int i = 0; i < massive.Length; i++)
        Console.WriteLine($"\t\t{i + 1} \t   {massive[i]:0.0000}");
}
double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
// закончились методы, началось тело программы
FillArray(array);
PrintArray(array);
Console.WriteLine($"Максимальный элемент массива равен : \t{FindMax(array):0.0000} \nМинимальный элемент массива равен : \t{FindMin(array):0.0000} ");
Console.WriteLine($"Разница между ними равна : \t\t{FindMax(array) - FindMin(array):0.0000}\n");





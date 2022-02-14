// Показать двумерный массив размером m×n заполненный целыми числами

Console.Clear();

Console.Write("Задайте количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n]; 
void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

Console.WriteLine();

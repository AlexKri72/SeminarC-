// Написать программу копирования массива

Console.Clear();

int[] array_1 = new int[20];
int[] array_2 = new int[array_1.Length];

void FillArray(int[] massive) //заполняем первый массив числами
{
    for (int i = 0; i < massive.Length; i++) massive[i] = new Random().Next(1, 10001);
}
void PrintArray(int[] massive) //метод печати массива
{
    for (int i = 0; i < massive.Length; i++) Console.Write($"{massive[i]}  ");
}
void CopyArray(int[] arr, int[] mass)  //метод копирования массива
{
    for (int i = 0; i < arr.Length; i++) mass[i] = arr[i];
}
FillArray(array_1);
Console.WriteLine("Первоначально заданный массив:");
PrintArray(array_1);
CopyArray(array_1, array_2);
Console.WriteLine("\nСкопированный массив:");
PrintArray(array_2);

Console.WriteLine("\n");

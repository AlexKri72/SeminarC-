// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
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
        Console.Write($"{array[i]}  ");
}
FillArray(array);
PrintArray(array);
int positive = 0;
int negative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0) positive += array[i];
    if (array[i]<0) negative += array[i];
}

Console.WriteLine($" \n Сумма положительных чисел массива равна {positive}, отрицательных   {negative}");

Console.WriteLine();
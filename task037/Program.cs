// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();

int[] array = new int[123];

void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(1, 1000);
}
// закончились методы, началось тело программы
FillArray(array);

int a = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] >= 10 && array[i] <= 99) a++;

Console.WriteLine($"\nВ массиве содержится {a} двузначных чисел.\n");
Console.WriteLine();


// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
// Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();

int[] array = new int[20];

void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} \t ");
}
// закончились методы, началось тело программы

FillArray(array);
PrintArray(array);
int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) even++;
    else odd++;
}

Console.WriteLine($"\nВ массиве содержится {even} чётных и {odd} нечётных чисел.");
Console.WriteLine();

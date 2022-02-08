// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[] array = new int[11];

void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(1, 100);
}

// закончились методы, началось тело программы
FillArray(array);

int j = 0;
Console.WriteLine("\t Номер позиции \tЭлемент массива \tСумма пар");
for (int i = 0; i < array.Length; i++)
{
    j = array.Length - i - 1;
    Console.Write($"\t \t{i} \t \t{array[i]}");
    if (i == j) Console.WriteLine($"\t\t{array[i]}");
    else Console.WriteLine($"\t\t{array[i] + array[j]}");
}
Console.WriteLine();
Console.WriteLine();

// Найти сумму чисел одномерного массива, стоящих на нечетной позиции

Console.Clear();

int[] array = new int[5];

void FillArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        massive[i] = new Random().Next(1, 100);
}
void PrintArray(int[] massive)
{
    Console.WriteLine("\t Номер позиции \tЭлемент массива");
    for (int i = 0; i < massive.Length; i++)
        Console.WriteLine($"\t \t{i} \t \t{massive[i]}");
}
// закончились методы, началось тело программы
FillArray(array);
PrintArray(array);
int a = 0;
for (int i = 1; i < array.Length; i += 2) a += array[i];

Console.WriteLine($"\nСумма чисел массива, расположенных на нечётных позициях, равна {a} .\n\n");




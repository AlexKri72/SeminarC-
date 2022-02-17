// Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();

Console.Write("Сколько чисел будем вводить? :");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n]; // задаем размер массива
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0) count++; // считаем положительные числа
}

Console.WriteLine($"\nВведено {count} чисел больше нуля.\n");

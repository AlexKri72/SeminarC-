// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();

string[] week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine());
if (n >= 1 && n <= 5)   Console.WriteLine($"Не угадали, {week[n-1]} это рабочий день!");
if (n == 6 || n == 7)   Console.WriteLine($"Ура,  {week[n-1]} это выходной!");
if (n < 1 || n > 7)     Console.WriteLine("Такого дня недели не бывает!");

Console.WriteLine();
